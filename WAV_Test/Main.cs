using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;


//Credit to Dan Waters, MS .NET Developer:
//Copyright 6 June, 2009

namespace WAV_Test
{
    public partial class Main : Form
    {
        float frequency_single = 200;
        float volume_single = .5f;
        float duration_single = .1f;
        float frequency_many = 200;
        float volume_many = .5f;
        float duration_many = .1f;

        public Main()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string filePath = filepathTextBox1.Text;
            WaveGenerator wave = new WaveGenerator(WaveExampleType.Sine, frequency_single, volume_single, duration_single);
            wave.Save(filePath);
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = this.Width - 40;
            tabControl1.Height = this.Height - 65;
        }

        private void browse1(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            filepathTextBox1.Text = folderPath;

        }

        private void frequencyTrackBar1_Scroll(object sender, EventArgs e)
        {
            frequency_single = 200 + (frequencyTrackBar1.Value * 10);
            frequencyTextBox1.Text = frequency_single.ToString();
        }

        private void volumeTrackBar1_Scroll(object sender, EventArgs e)
        {
            volume_single = (float)volumeTrackBar1.Value / 100f;
            volumeTextBox1.Text = (volume_single * 100f).ToString() + "%";
        }

        private void durationTrackBar1_Scroll(object sender, EventArgs e)
        {
            duration_single = durationTrackBar1.Value * .025f;
            durationTextBox1.Text = ((int)(duration_single * 1000)).ToString();
        }

        private void GenerateMultipleWaves_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string filePath = filepathTextBox2.Text;
            WaveGenerator wave;
            int samples;
            float fDiff, vDiff, dDiff;

            if(! Int32.TryParse(numberOfSamples.Text, out samples)){
                MessageBox.Show("You must enter a number for the number of samples.");
                return;
            }
 
            else if (!float.TryParse(freqDiff.Text, out fDiff))
            {
                MessageBox.Show("You must enter a number for the difference in frequency.");
                return;
            }
            else if (!float.TryParse(volDiff.Text, out vDiff))
            {
                MessageBox.Show("You must enter a number for the difference in volume.");
                return;
            }
            else if (!float.TryParse(durDiff.Text, out dDiff))
            {
                MessageBox.Show("You must enter a number for the difference in duration.");
                return;
            } 

            for (int i = 0; i < samples; ++i)
            {
                wave = new WaveGenerator(WaveExampleType.Sine, frequency_many+((i-1)*fDiff), volume_many+((i-1)*vDiff), duration_many+((i-1)*dDiff));
                if (prefixRadioButton.Checked) wave.Save(filePath + namingConvention.Text + i.ToString() + ".wav");
                else wave.Save(filePath + i.ToString() + namingConvention.Text + ".wav");
            }
            Cursor = Cursors.Default;
        }

        private void frequencyTrackBar2_Scroll(object sender, EventArgs e)
        {
            frequency_many = 200 + (frequencyTrackBar2.Value * 10);
            frequencyTextBox2.Text = frequency_many.ToString();
        }

        private void BrowseMulti_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            filepathTextBox2.Text = folderPath + "\\";
        }

        private void volumeTrackBar2_Scroll(object sender, EventArgs e)
        {
            volume_many = (float)volumeTrackBar2.Value / 100f;
            volumeTextBox2.Text = (volume_many * 100f).ToString() + "%";
        }

        private void durationTrackBar2_Scroll(object sender, EventArgs e)
        {
            duration_many = durationTrackBar2.Value * .025f;
            durationTextBox2.Text = ((int)(duration_many * 1000)).ToString();
        }


    }
}
