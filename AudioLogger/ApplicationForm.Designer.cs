﻿namespace AudioLogger.Application
{
    partial class ApplicationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.cb_soundcard = new System.Windows.Forms.ComboBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.inzinierius = new System.ComponentModel.BackgroundWorker();
            this.cb_lenght = new System.Windows.Forms.ComboBox();
            this.cb_path_wav = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_keepMp3 = new System.Windows.Forms.CheckBox();
            this.cb_keepWav = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_path_mp3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.r_mp3 = new System.Windows.Forms.RadioButton();
            this.r_wav = new System.Windows.Forms.RadioButton();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_hostname = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_fileUploadDir = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_uploadType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_soundcard
            // 
            this.cb_soundcard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_soundcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_soundcard.FormattingEnabled = true;
            this.cb_soundcard.Location = new System.Drawing.Point(6, 19);
            this.cb_soundcard.Name = "cb_soundcard";
            this.cb_soundcard.Size = new System.Drawing.Size(380, 21);
            this.cb_soundcard.TabIndex = 5;
            this.cb_soundcard.SelectedValueChanged += new System.EventHandler(this.set_device);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Location = new System.Drawing.Point(304, 227);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(94, 23);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(304, 197);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 23);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // inzinierius
            // 
            this.inzinierius.WorkerReportsProgress = true;
            this.inzinierius.WorkerSupportsCancellation = true;
            this.inzinierius.DoWork += new System.ComponentModel.DoWorkEventHandler(this.inzinierius_DoWork);
            this.inzinierius.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.inzinierius_RunWorkCompleted);
            // 
            // cb_lenght
            // 
            this.cb_lenght.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_lenght.FormattingEnabled = true;
            this.cb_lenght.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.cb_lenght.Location = new System.Drawing.Point(148, 72);
            this.cb_lenght.Name = "cb_lenght";
            this.cb_lenght.Size = new System.Drawing.Size(71, 21);
            this.cb_lenght.TabIndex = 12;
            // 
            // cb_path_wav
            // 
            this.cb_path_wav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_path_wav.FormattingEnabled = true;
            this.cb_path_wav.Items.AddRange(new object[] {
            "E:\\_AudioLogger",
            "C:",
            "D:"});
            this.cb_path_wav.Location = new System.Drawing.Point(69, 19);
            this.cb_path_wav.Name = "cb_path_wav";
            this.cb_path_wav.Size = new System.Drawing.Size(150, 21);
            this.cb_path_wav.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_soundcard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_keepMp3);
            this.groupBox2.Controls.Add(this.cb_keepWav);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_path_mp3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_path_wav);
            this.groupBox2.Controls.Add(this.cb_lenght);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 102);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File settings";
            // 
            // cb_keepMp3
            // 
            this.cb_keepMp3.AutoSize = true;
            this.cb_keepMp3.Location = new System.Drawing.Point(225, 48);
            this.cb_keepMp3.Name = "cb_keepMp3";
            this.cb_keepMp3.Size = new System.Drawing.Size(118, 17);
            this.cb_keepMp3.TabIndex = 23;
            this.cb_keepMp3.Text = "Keep local .mp3 file";
            this.cb_keepMp3.UseVisualStyleBackColor = true;
            // 
            // cb_keepWav
            // 
            this.cb_keepWav.AutoSize = true;
            this.cb_keepWav.Location = new System.Drawing.Point(225, 21);
            this.cb_keepWav.Name = "cb_keepWav";
            this.cb_keepWav.Size = new System.Drawing.Size(118, 17);
            this.cb_keepWav.TabIndex = 22;
            this.cb_keepWav.Text = "Keep local .wav file";
            this.cb_keepWav.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(225, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 21);
            this.progressBar1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time span (min):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = ".mp3 path:";
            // 
            // cb_path_mp3
            // 
            this.cb_path_mp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_path_mp3.FormattingEnabled = true;
            this.cb_path_mp3.Items.AddRange(new object[] {
            "E:\\_AudioLogger",
            "C:",
            "D:"});
            this.cb_path_mp3.Location = new System.Drawing.Point(69, 45);
            this.cb_path_mp3.Name = "cb_path_mp3";
            this.cb_path_mp3.Size = new System.Drawing.Size(150, 21);
            this.cb_path_mp3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = ".wav path:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_password);
            this.groupBox3.Controls.Add(this.tb_username);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_directory);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_hostname);
            this.groupBox3.Location = new System.Drawing.Point(12, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FTP";
            // 
            // r_mp3
            // 
            this.r_mp3.AutoSize = true;
            this.r_mp3.Checked = true;
            this.r_mp3.Location = new System.Drawing.Point(227, 19);
            this.r_mp3.Name = "r_mp3";
            this.r_mp3.Size = new System.Drawing.Size(48, 17);
            this.r_mp3.TabIndex = 26;
            this.r_mp3.TabStop = true;
            this.r_mp3.Text = ".mp3";
            this.r_mp3.UseVisualStyleBackColor = true;
            // 
            // r_wav
            // 
            this.r_wav.AutoSize = true;
            this.r_wav.Location = new System.Drawing.Point(171, 19);
            this.r_wav.Name = "r_wav";
            this.r_wav.Size = new System.Drawing.Size(48, 17);
            this.r_wav.TabIndex = 25;
            this.r_wav.Text = ".wav";
            this.r_wav.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Location = new System.Drawing.Point(69, 76);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(206, 13);
            this.tb_password.TabIndex = 7;
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Location = new System.Drawing.Point(69, 57);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(206, 13);
            this.tb_username.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Username:";
            // 
            // tb_directory
            // 
            this.tb_directory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_directory.Location = new System.Drawing.Point(69, 38);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(206, 13);
            this.tb_directory.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Directory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hostname:";
            // 
            // tb_hostname
            // 
            this.tb_hostname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hostname.Location = new System.Drawing.Point(69, 19);
            this.tb_hostname.Name = "tb_hostname";
            this.tb_hostname.Size = new System.Drawing.Size(206, 13);
            this.tb_hostname.TabIndex = 0;
            // 
            // bt_Save
            // 
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(304, 382);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(94, 23);
            this.bt_Save.TabIndex = 18;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_fileUploadDir);
            this.groupBox4.Location = new System.Drawing.Point(12, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 57);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Directory";
            // 
            // tb_fileUploadDir
            // 
            this.tb_fileUploadDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fileUploadDir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tb_fileUploadDir.Location = new System.Drawing.Point(10, 19);
            this.tb_fileUploadDir.Name = "tb_fileUploadDir";
            this.tb_fileUploadDir.Size = new System.Drawing.Size(265, 20);
            this.tb_fileUploadDir.TabIndex = 0;
            this.tb_fileUploadDir.Text = "C:\\";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_uploadType);
            this.groupBox5.Controls.Add(this.r_wav);
            this.groupBox5.Controls.Add(this.r_mp3);
            this.groupBox5.Location = new System.Drawing.Point(12, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 51);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Upload settings";
            // 
            // cb_uploadType
            // 
            this.cb_uploadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uploadType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_uploadType.FormattingEnabled = true;
            this.cb_uploadType.Items.AddRange(new object[] {
            "FTP",
            "Directory"});
            this.cb_uploadType.Location = new System.Drawing.Point(10, 18);
            this.cb_uploadType.Name = "cb_uploadType";
            this.cb_uploadType.Size = new System.Drawing.Size(145, 21);
            this.cb_uploadType.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(418, 418);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_stop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioLogger v1.2";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.ComponentModel.BackgroundWorker inzinierius;
        public System.Windows.Forms.ComboBox cb_soundcard;
        public System.Windows.Forms.ComboBox cb_lenght;
        private System.Windows.Forms.ComboBox cb_path_wav;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_path_mp3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hostname;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cb_keepMp3;
        private System.Windows.Forms.CheckBox cb_keepWav;
        private System.Windows.Forms.RadioButton r_mp3;
        private System.Windows.Forms.RadioButton r_wav;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_fileUploadDir;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ComboBox cb_uploadType;
    }
}
