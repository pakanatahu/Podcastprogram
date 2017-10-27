namespace Gruppprojekt
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.tbIntervall = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDownload = new System.Windows.Forms.Label();
            this.btPlayPause = new System.Windows.Forms.Button();
            this.btQuitMusicPlayback = new System.Windows.Forms.Button();
            this.lbNowPlaying = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "bt_add";
            this.button1.Location = new System.Drawing.Point(246, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(84, 16);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleDescription = "lb_main_content";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 82);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inställningar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AccessibleName = "bt_manage_categories";
            this.button3.Location = new System.Drawing.Point(211, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hantera kategorier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btPlay
            // 
            this.btPlay.AccessibleName = "bt_play";
            this.btPlay.Location = new System.Drawing.Point(3, 157);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 6;
            this.btPlay.Text = "Spela upp";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Visa mer";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Namn";
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(482, 45);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(142, 20);
            this.tbNamn.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.AccessibleDescription = "bt_add_ok";
            this.button8.Location = new System.Drawing.Point(549, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "OK";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tbIntervall
            // 
            this.tbIntervall.Location = new System.Drawing.Point(482, 122);
            this.tbIntervall.Name = "tbIntervall";
            this.tbIntervall.Size = new System.Drawing.Size(142, 20);
            this.tbIntervall.TabIndex = 15;
            this.tbIntervall.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Intervall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategori";
            // 
            // cbCategory2
            // 
            this.cbCategory2.FormattingEnabled = true;
            this.cbCategory2.Location = new System.Drawing.Point(482, 95);
            this.cbCategory2.Name = "cbCategory2";
            this.cbCategory2.Size = new System.Drawing.Size(142, 21);
            this.cbCategory2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "URL";
            // 
            // tbURL
            // 
            this.tbURL.AccessibleName = "tb_url";
            this.tbURL.Location = new System.Drawing.Point(482, 69);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(142, 20);
            this.tbURL.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lägg till ny podcast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Podcasts";
            // 
            // lbDownload
            // 
            this.lbDownload.AutoSize = true;
            this.lbDownload.Location = new System.Drawing.Point(133, 297);
            this.lbDownload.Name = "lbDownload";
            this.lbDownload.Size = new System.Drawing.Size(0, 13);
            this.lbDownload.TabIndex = 24;
            // 
            // btPlayPause
            // 
            this.btPlayPause.Location = new System.Drawing.Point(3, 186);
            this.btPlayPause.Name = "btPlayPause";
            this.btPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btPlayPause.TabIndex = 25;
            this.btPlayPause.Text = "Play/Pause";
            this.btPlayPause.UseVisualStyleBackColor = true;
            this.btPlayPause.Visible = false;
            this.btPlayPause.Click += new System.EventHandler(this.btPlayPause_Click);
            // 
            // btQuitMusicPlayback
            // 
            this.btQuitMusicPlayback.Location = new System.Drawing.Point(84, 186);
            this.btQuitMusicPlayback.Name = "btQuitMusicPlayback";
            this.btQuitMusicPlayback.Size = new System.Drawing.Size(75, 23);
            this.btQuitMusicPlayback.TabIndex = 26;
            this.btQuitMusicPlayback.Text = "Avbryt";
            this.btQuitMusicPlayback.UseVisualStyleBackColor = true;
            this.btQuitMusicPlayback.Visible = false;
            this.btQuitMusicPlayback.Click += new System.EventHandler(this.btQuitMusicPlayback_Click);
            // 
            // lbNowPlaying
            // 
            this.lbNowPlaying.AutoSize = true;
            this.lbNowPlaying.Location = new System.Drawing.Point(246, 297);
            this.lbNowPlaying.Name = "lbNowPlaying";
            this.lbNowPlaying.Size = new System.Drawing.Size(0, 13);
            this.lbNowPlaying.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbNowPlaying);
            this.Controls.Add(this.btQuitMusicPlayback);
            this.Controls.Add(this.btPlayPause);
            this.Controls.Add(this.lbDownload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.tbIntervall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbIntervall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDownload;
        private System.Windows.Forms.Button btPlayPause;
        private System.Windows.Forms.Button btQuitMusicPlayback;
        private System.Windows.Forms.Label lbNowPlaying;
        private System.Windows.Forms.Button button4;
    }
}

