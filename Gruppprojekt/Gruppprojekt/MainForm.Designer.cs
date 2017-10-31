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
            this.ListBoxPodcasts = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.LabelFeeds = new System.Windows.Forms.Label();
            this.ListBoxFeeds = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.LabelManageFeed = new System.Windows.Forms.Label();
            this.ComboBoxFeeds = new System.Windows.Forms.ComboBox();
            this.TextBoxURL = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelManageURL = new System.Windows.Forms.Label();
            this.LabelManageName = new System.Windows.Forms.Label();
            this.TextBoxManageCategory = new System.Windows.Forms.TextBox();
            this.LabelManageCategory = new System.Windows.Forms.Label();
            this.TextBoxManageUpdateInterval = new System.Windows.Forms.TextBox();
            this.LabelManageUpdateInterval = new System.Windows.Forms.Label();
            this.ButtonManageFeeds = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.btnCreateNewCategory = new System.Windows.Forms.Button();
            this.cbCategory3 = new System.Windows.Forms.ComboBox();
            this.btnChangeCategoryName = new System.Windows.Forms.Button();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonRemoveFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "bt_add";
            this.button1.Location = new System.Drawing.Point(255, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // ListBoxPodcasts
            // 
            this.ListBoxPodcasts.AccessibleDescription = "";
            this.ListBoxPodcasts.FormattingEnabled = true;
            this.ListBoxPodcasts.Location = new System.Drawing.Point(26, 222);
            this.ListBoxPodcasts.Name = "ListBoxPodcasts";
            this.ListBoxPodcasts.Size = new System.Drawing.Size(298, 82);
            this.ListBoxPodcasts.TabIndex = 3;
            this.ListBoxPodcasts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inställningar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btPlay
            // 
            this.btPlay.AccessibleName = "bt_play";
            this.btPlay.Location = new System.Drawing.Point(12, 314);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 6;
            this.btPlay.Text = "Spela upp";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 314);
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
            this.tbIntervall.Text = "HH:MM";
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
            this.cbCategory2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lägg till ny feed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 206);
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
            this.btPlayPause.Location = new System.Drawing.Point(12, 343);
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
            this.btQuitMusicPlayback.Location = new System.Drawing.Point(93, 343);
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
            this.lbNowPlaying.Location = new System.Drawing.Point(174, 348);
            this.lbNowPlaying.Name = "lbNowPlaying";
            this.lbNowPlaying.Size = new System.Drawing.Size(0, 13);
            this.lbNowPlaying.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(431, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // LabelFeeds
            // 
            this.LabelFeeds.AutoSize = true;
            this.LabelFeeds.Location = new System.Drawing.Point(32, 49);
            this.LabelFeeds.Name = "LabelFeeds";
            this.LabelFeeds.Size = new System.Drawing.Size(36, 13);
            this.LabelFeeds.TabIndex = 29;
            this.LabelFeeds.Text = "Feeds";
            // 
            // ListBoxFeeds
            // 
            this.ListBoxFeeds.FormattingEnabled = true;
            this.ListBoxFeeds.Location = new System.Drawing.Point(26, 69);
            this.ListBoxFeeds.Name = "ListBoxFeeds";
            this.ListBoxFeeds.Size = new System.Drawing.Size(295, 95);
            this.ListBoxFeeds.TabIndex = 30;
            this.ListBoxFeeds.SelectedIndexChanged += new System.EventHandler(this.ListBoxFeeds_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(340, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // LabelManageFeed
            // 
            this.LabelManageFeed.AutoSize = true;
            this.LabelManageFeed.Location = new System.Drawing.Point(706, 19);
            this.LabelManageFeed.Name = "LabelManageFeed";
            this.LabelManageFeed.Size = new System.Drawing.Size(59, 13);
            this.LabelManageFeed.TabIndex = 32;
            this.LabelManageFeed.Text = "Ändra feed";
            // 
            // ComboBoxFeeds
            // 
            this.ComboBoxFeeds.FormattingEnabled = true;
            this.ComboBoxFeeds.Location = new System.Drawing.Point(726, 41);
            this.ComboBoxFeeds.Name = "ComboBoxFeeds";
            this.ComboBoxFeeds.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFeeds.TabIndex = 33;

            // 
            // TextBoxURL
            // 
            this.TextBoxURL.Location = new System.Drawing.Point(747, 76);
            this.TextBoxURL.Name = "TextBoxURL";
            this.TextBoxURL.Size = new System.Drawing.Size(100, 20);
            this.TextBoxURL.TabIndex = 34;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(747, 102);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 35;
            // 
            // LabelManageURL
            // 
            this.LabelManageURL.AutoSize = true;
            this.LabelManageURL.Location = new System.Drawing.Point(695, 79);
            this.LabelManageURL.Name = "LabelManageURL";
            this.LabelManageURL.Size = new System.Drawing.Size(29, 13);
            this.LabelManageURL.TabIndex = 36;
            this.LabelManageURL.Text = "URL";
            // 
            // LabelManageName
            // 
            this.LabelManageName.AutoSize = true;
            this.LabelManageName.Location = new System.Drawing.Point(695, 109);
            this.LabelManageName.Name = "LabelManageName";
            this.LabelManageName.Size = new System.Drawing.Size(35, 13);
            this.LabelManageName.TabIndex = 37;
            this.LabelManageName.Text = "Name";
            // 
            // TextBoxManageCategory
            // 
            this.TextBoxManageCategory.Location = new System.Drawing.Point(747, 129);
            this.TextBoxManageCategory.Name = "TextBoxManageCategory";
            this.TextBoxManageCategory.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManageCategory.TabIndex = 38;
            // 
            // LabelManageCategory
            // 
            this.LabelManageCategory.AutoSize = true;
            this.LabelManageCategory.Location = new System.Drawing.Point(695, 132);
            this.LabelManageCategory.Name = "LabelManageCategory";
            this.LabelManageCategory.Size = new System.Drawing.Size(46, 13);
            this.LabelManageCategory.TabIndex = 39;
            this.LabelManageCategory.Text = "Kategori";
            // 
            // TextBoxManageUpdateInterval
            // 
            this.TextBoxManageUpdateInterval.Location = new System.Drawing.Point(747, 155);
            this.TextBoxManageUpdateInterval.Name = "TextBoxManageUpdateInterval";
            this.TextBoxManageUpdateInterval.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManageUpdateInterval.TabIndex = 40;
            // 
            // LabelManageUpdateInterval
            // 
            this.LabelManageUpdateInterval.AutoSize = true;
            this.LabelManageUpdateInterval.Location = new System.Drawing.Point(695, 158);
            this.LabelManageUpdateInterval.Name = "LabelManageUpdateInterval";
            this.LabelManageUpdateInterval.Size = new System.Drawing.Size(42, 13);
            this.LabelManageUpdateInterval.TabIndex = 41;
            this.LabelManageUpdateInterval.Text = "Interval";
            // 
            // ButtonManageFeeds
            // 
            this.ButtonManageFeeds.Location = new System.Drawing.Point(772, 181);
            this.ButtonManageFeeds.Name = "ButtonManageFeeds";
            this.ButtonManageFeeds.Size = new System.Drawing.Size(75, 23);
            this.ButtonManageFeeds.TabIndex = 42;
            this.ButtonManageFeeds.Text = "OK";
            this.ButtonManageFeeds.UseVisualStyleBackColor = true;
            this.ButtonManageFeeds.Click += new System.EventHandler(this.ButtonManageFeeds_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Lägg till kategori";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Välj kategori";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(627, 253);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCategory.TabIndex = 49;
            this.btnRemoveCategory.Text = "Ta bort";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.Location = new System.Drawing.Point(483, 340);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(121, 20);
            this.tbAddCategory.TabIndex = 48;
            // 
            // btnCreateNewCategory
            // 
            this.btnCreateNewCategory.Location = new System.Drawing.Point(627, 340);
            this.btnCreateNewCategory.Name = "btnCreateNewCategory";
            this.btnCreateNewCategory.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewCategory.TabIndex = 47;
            this.btnCreateNewCategory.Text = "Skapa";
            this.btnCreateNewCategory.UseVisualStyleBackColor = true;
            this.btnCreateNewCategory.Click += new System.EventHandler(this.btnCreateNewCategory_Click);
            // 
            // cbCategory3
            // 
            this.cbCategory3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory3.FormattingEnabled = true;
            this.cbCategory3.Location = new System.Drawing.Point(483, 253);
            this.cbCategory3.Name = "cbCategory3";
            this.cbCategory3.Size = new System.Drawing.Size(121, 21);
            this.cbCategory3.TabIndex = 46;
            // 
            // btnChangeCategoryName
            // 
            this.btnChangeCategoryName.Location = new System.Drawing.Point(627, 291);
            this.btnChangeCategoryName.Name = "btnChangeCategoryName";
            this.btnChangeCategoryName.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCategoryName.TabIndex = 45;
            this.btnChangeCategoryName.Text = "Spara";
            this.btnChangeCategoryName.UseVisualStyleBackColor = true;
            this.btnChangeCategoryName.Click += new System.EventHandler(this.btnChangeCategoryName_Click);
            // 
            // tbNewName
            // 
            this.tbNewName.AccessibleName = "tb_manage_name";
            this.tbNewName.Location = new System.Drawing.Point(483, 291);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(121, 20);
            this.tbNewName.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Nytt namn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Hantera Kategorier";
            // 
            // ButtonRemoveFeed
            // 
            this.ButtonRemoveFeed.Location = new System.Drawing.Point(690, 181);
            this.ButtonRemoveFeed.Name = "ButtonRemoveFeed";
            this.ButtonRemoveFeed.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemoveFeed.TabIndex = 54;
            this.ButtonRemoveFeed.Text = "Ta bort";
            this.ButtonRemoveFeed.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 424);
            this.Controls.Add(this.ButtonRemoveFeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.tbAddCategory);
            this.Controls.Add(this.btnCreateNewCategory);
            this.Controls.Add(this.cbCategory3);
            this.Controls.Add(this.btnChangeCategoryName);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ButtonManageFeeds);
            this.Controls.Add(this.LabelManageUpdateInterval);
            this.Controls.Add(this.TextBoxManageUpdateInterval);
            this.Controls.Add(this.LabelManageCategory);
            this.Controls.Add(this.TextBoxManageCategory);
            this.Controls.Add(this.LabelManageName);
            this.Controls.Add(this.LabelManageURL);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxURL);
            this.Controls.Add(this.ComboBoxFeeds);
            this.Controls.Add(this.LabelManageFeed);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ListBoxFeeds);
            this.Controls.Add(this.LabelFeeds);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListBoxPodcasts);
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
        private System.Windows.Forms.ListBox ListBoxPodcasts;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label LabelFeeds;
        private System.Windows.Forms.ListBox ListBoxFeeds;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label LabelManageFeed;
        private System.Windows.Forms.ComboBox ComboBoxFeeds;
        private System.Windows.Forms.TextBox TextBoxURL;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelManageURL;
        private System.Windows.Forms.Label LabelManageName;
        private System.Windows.Forms.TextBox TextBoxManageCategory;
        private System.Windows.Forms.Label LabelManageCategory;
        private System.Windows.Forms.TextBox TextBoxManageUpdateInterval;
        private System.Windows.Forms.Label LabelManageUpdateInterval;
        private System.Windows.Forms.Button ButtonManageFeeds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.TextBox tbAddCategory;
        private System.Windows.Forms.Button btnCreateNewCategory;
        private System.Windows.Forms.ComboBox cbCategory3;
        private System.Windows.Forms.Button btnChangeCategoryName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonRemoveFeed;
    }
}

