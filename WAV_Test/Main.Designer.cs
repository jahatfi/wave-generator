namespace WAV_Test
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateSingleWave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.durationTrackBar1 = new System.Windows.Forms.TrackBar();
            this.durationTextBox1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.volumeTextBox1 = new System.Windows.Forms.Label();
            this.frequencyTextBox1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseSingle = new System.Windows.Forms.Button();
            this.filepathTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frequencyTrackBar1 = new System.Windows.Forms.TrackBar();
            this.volumeTrackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.suffixRadioButton = new System.Windows.Forms.RadioButton();
            this.prefixRadioButton = new System.Windows.Forms.RadioButton();
            this.namingConvention = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numberOfSamples = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.durDiff = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.volDiff = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.freqDiff = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.durationTextBox2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.durationTrackBar2 = new System.Windows.Forms.TrackBar();
            this.volumeTextBox2 = new System.Windows.Forms.Label();
            this.frequencyTextBox2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.frequencyTrackBar2 = new System.Windows.Forms.TrackBar();
            this.volumeTrackBar2 = new System.Windows.Forms.TrackBar();
            this.GenerateMultipleWaves = new System.Windows.Forms.Button();
            this.BrowseMulti = new System.Windows.Forms.Button();
            this.filepathTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateSingleWave
            // 
            this.GenerateSingleWave.Location = new System.Drawing.Point(168, 400);
            this.GenerateSingleWave.Name = "GenerateSingleWave";
            this.GenerateSingleWave.Size = new System.Drawing.Size(169, 63);
            this.GenerateSingleWave.TabIndex = 0;
            this.GenerateSingleWave.Text = "Generate Wave";
            this.GenerateSingleWave.UseVisualStyleBackColor = true;
            this.GenerateSingleWave.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 535);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.durationTrackBar1);
            this.tabPage1.Controls.Add(this.durationTextBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.volumeTextBox1);
            this.tabPage1.Controls.Add(this.frequencyTextBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.browseSingle);
            this.tabPage1.Controls.Add(this.filepathTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.frequencyTrackBar1);
            this.tabPage1.Controls.Add(this.volumeTrackBar1);
            this.tabPage1.Controls.Add(this.GenerateSingleWave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Sample";
            // 
            // durationTrackBar1
            // 
            this.durationTrackBar1.Location = new System.Drawing.Point(20, 339);
            this.durationTrackBar1.Maximum = 100;
            this.durationTrackBar1.Name = "durationTrackBar1";
            this.durationTrackBar1.Size = new System.Drawing.Size(481, 45);
            this.durationTrackBar1.TabIndex = 15;
            this.durationTrackBar1.Value = 10;
            this.durationTrackBar1.Scroll += new System.EventHandler(this.durationTrackBar1_Scroll);
            // 
            // durationTextBox1
            // 
            this.durationTextBox1.AutoSize = true;
            this.durationTextBox1.Location = new System.Drawing.Point(96, 309);
            this.durationTextBox1.Name = "durationTextBox1";
            this.durationTextBox1.Size = new System.Drawing.Size(25, 13);
            this.durationTextBox1.TabIndex = 14;
            this.durationTextBox1.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Duration (ms):";
            // 
            // volumeTextBox1
            // 
            this.volumeTextBox1.AutoSize = true;
            this.volumeTextBox1.Location = new System.Drawing.Point(96, 233);
            this.volumeTextBox1.Name = "volumeTextBox1";
            this.volumeTextBox1.Size = new System.Drawing.Size(27, 13);
            this.volumeTextBox1.TabIndex = 11;
            this.volumeTextBox1.Text = "50%";
            // 
            // frequencyTextBox1
            // 
            this.frequencyTextBox1.AutoSize = true;
            this.frequencyTextBox1.Location = new System.Drawing.Point(105, 159);
            this.frequencyTextBox1.Name = "frequencyTextBox1";
            this.frequencyTextBox1.Size = new System.Drawing.Size(25, 13);
            this.frequencyTextBox1.TabIndex = 10;
            this.frequencyTextBox1.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Frequency (Hz):";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sawtooth",
            "Sine (recommended)",
            "Square",
            "Triangle",
            "White Noise"});
            this.comboBox1.Location = new System.Drawing.Point(20, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wave Type";
            // 
            // browseSingle
            // 
            this.browseSingle.Location = new System.Drawing.Point(20, 62);
            this.browseSingle.Name = "browseSingle";
            this.browseSingle.Size = new System.Drawing.Size(75, 23);
            this.browseSingle.TabIndex = 5;
            this.browseSingle.Text = "Browse";
            this.browseSingle.UseVisualStyleBackColor = true;
            this.browseSingle.Click += new System.EventHandler(this.browse1);
            // 
            // filepathTextBox1
            // 
            this.filepathTextBox1.Location = new System.Drawing.Point(20, 35);
            this.filepathTextBox1.Name = "filepathTextBox1";
            this.filepathTextBox1.Size = new System.Drawing.Size(231, 20);
            this.filepathTextBox1.TabIndex = 4;
            this.filepathTextBox1.Text = "C:\\Users\\jahatfi\\Desktop\\testing.wav";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save WAV file to:";
            // 
            // frequencyTrackBar1
            // 
            this.frequencyTrackBar1.Location = new System.Drawing.Point(20, 191);
            this.frequencyTrackBar1.Maximum = 180;
            this.frequencyTrackBar1.Name = "frequencyTrackBar1";
            this.frequencyTrackBar1.Size = new System.Drawing.Size(481, 45);
            this.frequencyTrackBar1.TabIndex = 2;
            this.frequencyTrackBar1.Scroll += new System.EventHandler(this.frequencyTrackBar1_Scroll);
            // 
            // volumeTrackBar1
            // 
            this.volumeTrackBar1.Location = new System.Drawing.Point(20, 258);
            this.volumeTrackBar1.Maximum = 100;
            this.volumeTrackBar1.Name = "volumeTrackBar1";
            this.volumeTrackBar1.Size = new System.Drawing.Size(481, 45);
            this.volumeTrackBar1.TabIndex = 1;
            this.volumeTrackBar1.Value = 50;
            this.volumeTrackBar1.Scroll += new System.EventHandler(this.volumeTrackBar1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.suffixRadioButton);
            this.tabPage2.Controls.Add(this.prefixRadioButton);
            this.tabPage2.Controls.Add(this.namingConvention);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.numberOfSamples);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.durDiff);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.volDiff);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.freqDiff);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.durationTextBox2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.durationTrackBar2);
            this.tabPage2.Controls.Add(this.volumeTextBox2);
            this.tabPage2.Controls.Add(this.frequencyTextBox2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.frequencyTrackBar2);
            this.tabPage2.Controls.Add(this.volumeTrackBar2);
            this.tabPage2.Controls.Add(this.GenerateMultipleWaves);
            this.tabPage2.Controls.Add(this.BrowseMulti);
            this.tabPage2.Controls.Add(this.filepathTextBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi-Sample";
            // 
            // suffixRadioButton
            // 
            this.suffixRadioButton.AutoSize = true;
            this.suffixRadioButton.Location = new System.Drawing.Point(133, 119);
            this.suffixRadioButton.Name = "suffixRadioButton";
            this.suffixRadioButton.Size = new System.Drawing.Size(271, 17);
            this.suffixRadioButton.TabIndex = 37;
            this.suffixRadioButton.Text = "Use as suffix (e.g. 1MyWave.wav, 2MyWav.wav,...)";
            this.suffixRadioButton.UseVisualStyleBackColor = true;
            // 
            // prefixRadioButton
            // 
            this.prefixRadioButton.AutoSize = true;
            this.prefixRadioButton.Checked = true;
            this.prefixRadioButton.Location = new System.Drawing.Point(133, 98);
            this.prefixRadioButton.Name = "prefixRadioButton";
            this.prefixRadioButton.Size = new System.Drawing.Size(272, 17);
            this.prefixRadioButton.TabIndex = 36;
            this.prefixRadioButton.TabStop = true;
            this.prefixRadioButton.Text = "Use as prefix (e.g. MyWave1.wav, MyWav2.wav,...)";
            this.prefixRadioButton.UseVisualStyleBackColor = true;
            // 
            // namingConvention
            // 
            this.namingConvention.Location = new System.Drawing.Point(20, 116);
            this.namingConvention.Name = "namingConvention";
            this.namingConvention.Size = new System.Drawing.Size(89, 20);
            this.namingConvention.TabIndex = 35;
            this.namingConvention.Text = "MyWave";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Naming Convention:";
            // 
            // numberOfSamples
            // 
            this.numberOfSamples.Location = new System.Drawing.Point(286, 34);
            this.numberOfSamples.Name = "numberOfSamples";
            this.numberOfSamples.Size = new System.Drawing.Size(89, 20);
            this.numberOfSamples.TabIndex = 33;
            this.numberOfSamples.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(286, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Number of Samples:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 480);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(461, 26);
            this.label17.TabIndex = 31;
            this.label17.Text = "*Use these options to produce tones with increasing or decreasing frequency, \r\nvo" +
                "lume, and/or duration. Note: Values will be capped between 0 and their respectiv" +
                "e maximums.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(193, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Difference* (ms):";
            // 
            // durDiff
            // 
            this.durDiff.Location = new System.Drawing.Point(284, 308);
            this.durDiff.Name = "durDiff";
            this.durDiff.Size = new System.Drawing.Size(89, 20);
            this.durDiff.TabIndex = 29;
            this.durDiff.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(193, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Difference* (%):";
            // 
            // volDiff
            // 
            this.volDiff.Location = new System.Drawing.Point(284, 232);
            this.volDiff.Name = "volDiff";
            this.volDiff.Size = new System.Drawing.Size(89, 20);
            this.volDiff.TabIndex = 27;
            this.volDiff.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(193, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Difference* (Hz):";
            // 
            // freqDiff
            // 
            this.freqDiff.Location = new System.Drawing.Point(284, 159);
            this.freqDiff.Name = "freqDiff";
            this.freqDiff.Size = new System.Drawing.Size(89, 20);
            this.freqDiff.TabIndex = 25;
            this.freqDiff.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "This may take a while.";
            // 
            // durationTextBox2
            // 
            this.durationTextBox2.AutoSize = true;
            this.durationTextBox2.Location = new System.Drawing.Point(124, 309);
            this.durationTextBox2.Name = "durationTextBox2";
            this.durationTextBox2.Size = new System.Drawing.Size(25, 13);
            this.durationTextBox2.TabIndex = 23;
            this.durationTextBox2.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Initial Duration (ms):";
            // 
            // durationTrackBar2
            // 
            this.durationTrackBar2.Location = new System.Drawing.Point(14, 334);
            this.durationTrackBar2.Maximum = 100;
            this.durationTrackBar2.Name = "durationTrackBar2";
            this.durationTrackBar2.Size = new System.Drawing.Size(486, 45);
            this.durationTrackBar2.TabIndex = 21;
            this.durationTrackBar2.Value = 10;
            this.durationTrackBar2.Scroll += new System.EventHandler(this.durationTrackBar2_Scroll);
            // 
            // volumeTextBox2
            // 
            this.volumeTextBox2.AutoSize = true;
            this.volumeTextBox2.Location = new System.Drawing.Point(99, 239);
            this.volumeTextBox2.Name = "volumeTextBox2";
            this.volumeTextBox2.Size = new System.Drawing.Size(27, 13);
            this.volumeTextBox2.TabIndex = 20;
            this.volumeTextBox2.Text = "50%";
            // 
            // frequencyTextBox2
            // 
            this.frequencyTextBox2.AutoSize = true;
            this.frequencyTextBox2.Location = new System.Drawing.Point(130, 159);
            this.frequencyTextBox2.Name = "frequencyTextBox2";
            this.frequencyTextBox2.Size = new System.Drawing.Size(25, 13);
            this.frequencyTextBox2.TabIndex = 19;
            this.frequencyTextBox2.Text = "200";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Initial Volume:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Inital Frequency (Hz):";
            // 
            // frequencyTrackBar2
            // 
            this.frequencyTrackBar2.Location = new System.Drawing.Point(14, 191);
            this.frequencyTrackBar2.Maximum = 180;
            this.frequencyTrackBar2.Name = "frequencyTrackBar2";
            this.frequencyTrackBar2.Size = new System.Drawing.Size(486, 45);
            this.frequencyTrackBar2.TabIndex = 16;
            this.frequencyTrackBar2.Scroll += new System.EventHandler(this.frequencyTrackBar2_Scroll);
            // 
            // volumeTrackBar2
            // 
            this.volumeTrackBar2.Location = new System.Drawing.Point(14, 258);
            this.volumeTrackBar2.Maximum = 100;
            this.volumeTrackBar2.Name = "volumeTrackBar2";
            this.volumeTrackBar2.Size = new System.Drawing.Size(486, 45);
            this.volumeTrackBar2.TabIndex = 15;
            this.volumeTrackBar2.Value = 50;
            this.volumeTrackBar2.Scroll += new System.EventHandler(this.volumeTrackBar2_Scroll);
            // 
            // GenerateMultipleWaves
            // 
            this.GenerateMultipleWaves.Location = new System.Drawing.Point(165, 384);
            this.GenerateMultipleWaves.Name = "GenerateMultipleWaves";
            this.GenerateMultipleWaves.Size = new System.Drawing.Size(169, 63);
            this.GenerateMultipleWaves.TabIndex = 9;
            this.GenerateMultipleWaves.Text = "Generate Waves";
            this.GenerateMultipleWaves.UseVisualStyleBackColor = true;
            this.GenerateMultipleWaves.Click += new System.EventHandler(this.GenerateMultipleWaves_Click);
            // 
            // BrowseMulti
            // 
            this.BrowseMulti.Location = new System.Drawing.Point(20, 62);
            this.BrowseMulti.Name = "BrowseMulti";
            this.BrowseMulti.Size = new System.Drawing.Size(75, 23);
            this.BrowseMulti.TabIndex = 8;
            this.BrowseMulti.Text = "Browse";
            this.BrowseMulti.UseVisualStyleBackColor = true;
            this.BrowseMulti.Click += new System.EventHandler(this.BrowseMulti_Click);
            // 
            // filepathTextBox2
            // 
            this.filepathTextBox2.Location = new System.Drawing.Point(20, 35);
            this.filepathTextBox2.Name = "filepathTextBox2";
            this.filepathTextBox2.Size = new System.Drawing.Size(231, 20);
            this.filepathTextBox2.TabIndex = 7;
            this.filepathTextBox2.Text = "C:\\Users\\jahatfi\\Desktop\\Pitches\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Save WAV files to folder:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Wave Generator";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateSingleWave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar volumeTrackBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseSingle;
        private System.Windows.Forms.TextBox filepathTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar frequencyTrackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label volumeTextBox1;
        private System.Windows.Forms.Label frequencyTextBox1;
        private System.Windows.Forms.Label durationTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label durationTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar durationTrackBar2;
        private System.Windows.Forms.Label volumeTextBox2;
        private System.Windows.Forms.Label frequencyTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar frequencyTrackBar2;
        private System.Windows.Forms.TrackBar volumeTrackBar2;
        private System.Windows.Forms.Button GenerateMultipleWaves;
        private System.Windows.Forms.Button BrowseMulti;
        private System.Windows.Forms.TextBox filepathTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberOfSamples;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox durDiff;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox volDiff;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox freqDiff;
        private System.Windows.Forms.RadioButton suffixRadioButton;
        private System.Windows.Forms.RadioButton prefixRadioButton;
        private System.Windows.Forms.TextBox namingConvention;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar durationTrackBar1;
    }
}

