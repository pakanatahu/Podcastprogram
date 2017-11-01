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
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.ListBoxPodcasts = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonShowMore = new System.Windows.Forms.Button();
            this.LabelAddRSSName = new System.Windows.Forms.Label();
            this.TextBoxAddRSSName = new System.Windows.Forms.TextBox();
            this.ButtonAddRSS = new System.Windows.Forms.Button();
            this.TextBoxAddRSSIntervall = new System.Windows.Forms.TextBox();
            this.LabelAddRSSUpdateInterval = new System.Windows.Forms.Label();
            this.LabelAddRSSCategory = new System.Windows.Forms.Label();
            this.ComboBoxAddRSS = new System.Windows.Forms.ComboBox();
            this.LabelAddRSSURL = new System.Windows.Forms.Label();
            this.TextBoxAddRSSURL = new System.Windows.Forms.TextBox();
            this.LabelAddRSS = new System.Windows.Forms.Label();
            this.LabelListBoxPodcasts = new System.Windows.Forms.Label();
            this.lbDownload = new System.Windows.Forms.Label();
            this.ButtonPlayPause = new System.Windows.Forms.Button();
            this.ButtonQuitMusicPlayback = new System.Windows.Forms.Button();
            this.lbNowPlaying = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.LabelListBoxFeeds = new System.Windows.Forms.Label();
            this.ListBoxFeeds = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.LabelManageFeed = new System.Windows.Forms.Label();
            this.ComboBoxManageFeed = new System.Windows.Forms.ComboBox();
            this.TextBoxManageFeedURL = new System.Windows.Forms.TextBox();
            this.TextBoxManageFeedName = new System.Windows.Forms.TextBox();
            this.LabelManageURL = new System.Windows.Forms.Label();
            this.LabelManageName = new System.Windows.Forms.Label();
            this.LabelManageCategory = new System.Windows.Forms.Label();
            this.TextBoxManageFeedUpdateInterval = new System.Windows.Forms.TextBox();
            this.LabelManageUpdateInterval = new System.Windows.Forms.Label();
            this.ButtonManageFeedOk = new System.Windows.Forms.Button();
            this.LabelManageCategoriesAdd = new System.Windows.Forms.Label();
            this.LabelManageCategoriesChoice = new System.Windows.Forms.Label();
            this.ButtonManageCategoriesRemove = new System.Windows.Forms.Button();
            this.TextBoxAddCategory = new System.Windows.Forms.TextBox();
            this.ButtonManageCategoriesCreate = new System.Windows.Forms.Button();
            this.ComboBoxManageCategories = new System.Windows.Forms.ComboBox();
            this.ButtonManageCategoriesSave = new System.Windows.Forms.Button();
            this.TextBoxManageCategoriesNewName = new System.Windows.Forms.TextBox();
            this.LabelManageCategoriesNewName = new System.Windows.Forms.Label();
            this.LabelManageCategories = new System.Windows.Forms.Label();
            this.ButtonManageFeedRemove = new System.Windows.Forms.Button();
            this.cbChangeFeedCategory = new System.Windows.Forms.ComboBox();
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
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(84, 16);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCategory.TabIndex = 1;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(23, 19);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCategory.Size = new System.Drawing.Size(46, 13);
            this.LabelCategory.TabIndex = 2;
            this.LabelCategory.Text = "Kategori";
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.AccessibleName = "";
            this.ButtonPlay.Location = new System.Drawing.Point(12, 314);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlay.TabIndex = 6;
            this.ButtonPlay.Text = "Spela upp";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonShowMore
            // 
            this.ButtonShowMore.Location = new System.Drawing.Point(93, 314);
            this.ButtonShowMore.Name = "ButtonShowMore";
            this.ButtonShowMore.Size = new System.Drawing.Size(56, 23);
            this.ButtonShowMore.TabIndex = 7;
            this.ButtonShowMore.Text = "Visa mer";
            this.ButtonShowMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonShowMore.UseVisualStyleBackColor = true;
            this.ButtonShowMore.Click += new System.EventHandler(this.ButtonShowMore_Click);
            // 
            // LabelAddRSSName
            // 
            this.LabelAddRSSName.AutoSize = true;
            this.LabelAddRSSName.Location = new System.Drawing.Point(418, 49);
            this.LabelAddRSSName.Name = "LabelAddRSSName";
            this.LabelAddRSSName.Size = new System.Drawing.Size(35, 13);
            this.LabelAddRSSName.TabIndex = 19;
            this.LabelAddRSSName.Text = "Namn";
            // 
            // TextBoxAddRSSName
            // 
            this.TextBoxAddRSSName.Location = new System.Drawing.Point(482, 45);
            this.TextBoxAddRSSName.Name = "TextBoxAddRSSName";
            this.TextBoxAddRSSName.Size = new System.Drawing.Size(142, 20);
            this.TextBoxAddRSSName.TabIndex = 18;
            // 
            // ButtonAddRSS
            // 
            this.ButtonAddRSS.Location = new System.Drawing.Point(549, 148);
            this.ButtonAddRSS.Name = "ButtonAddRSS";
            this.ButtonAddRSS.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddRSS.TabIndex = 16;
            this.ButtonAddRSS.Text = "OK";
            this.ButtonAddRSS.UseVisualStyleBackColor = true;
            this.ButtonAddRSS.Click += new System.EventHandler(this.ButtonAddRSS_Click);
            // 
            // TextBoxAddRSSIntervall
            // 
            this.TextBoxAddRSSIntervall.Location = new System.Drawing.Point(482, 122);
            this.TextBoxAddRSSIntervall.Name = "TextBoxAddRSSIntervall";
            this.TextBoxAddRSSIntervall.Size = new System.Drawing.Size(142, 20);
            this.TextBoxAddRSSIntervall.TabIndex = 15;
            this.TextBoxAddRSSIntervall.Text = "HH:MM";
            // 
            // LabelAddRSSUpdateInterval
            // 
            this.LabelAddRSSUpdateInterval.AutoSize = true;
            this.LabelAddRSSUpdateInterval.Location = new System.Drawing.Point(418, 125);
            this.LabelAddRSSUpdateInterval.Name = "LabelAddRSSUpdateInterval";
            this.LabelAddRSSUpdateInterval.Size = new System.Drawing.Size(44, 13);
            this.LabelAddRSSUpdateInterval.TabIndex = 14;
            this.LabelAddRSSUpdateInterval.Text = "Intervall";
            // 
            // LabelAddRSSCategory
            // 
            this.LabelAddRSSCategory.AutoSize = true;
            this.LabelAddRSSCategory.Location = new System.Drawing.Point(418, 98);
            this.LabelAddRSSCategory.Name = "LabelAddRSSCategory";
            this.LabelAddRSSCategory.Size = new System.Drawing.Size(46, 13);
            this.LabelAddRSSCategory.TabIndex = 13;
            this.LabelAddRSSCategory.Text = "Kategori";
            // 
            // ComboBoxAddRSS
            // 
            this.ComboBoxAddRSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAddRSS.FormattingEnabled = true;
            this.ComboBoxAddRSS.Location = new System.Drawing.Point(482, 95);
            this.ComboBoxAddRSS.Name = "ComboBoxAddRSS";
            this.ComboBoxAddRSS.Size = new System.Drawing.Size(142, 21);
            this.ComboBoxAddRSS.TabIndex = 12;
            this.ComboBoxAddRSS.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAddRSS_SelectedIndexChanged);
            // 
            // LabelAddRSSURL
            // 
            this.LabelAddRSSURL.AutoSize = true;
            this.LabelAddRSSURL.Location = new System.Drawing.Point(418, 75);
            this.LabelAddRSSURL.Name = "LabelAddRSSURL";
            this.LabelAddRSSURL.Size = new System.Drawing.Size(29, 13);
            this.LabelAddRSSURL.TabIndex = 11;
            this.LabelAddRSSURL.Text = "URL";
            // 
            // TextBoxAddRSSURL
            // 
            this.TextBoxAddRSSURL.AccessibleName = "tb_url";
            this.TextBoxAddRSSURL.Location = new System.Drawing.Point(482, 69);
            this.TextBoxAddRSSURL.Name = "TextBoxAddRSSURL";
            this.TextBoxAddRSSURL.Size = new System.Drawing.Size(142, 20);
            this.TextBoxAddRSSURL.TabIndex = 10;
            // 
            // LabelAddRSS
            // 
            this.LabelAddRSS.AutoSize = true;
            this.LabelAddRSS.Location = new System.Drawing.Point(479, 19);
            this.LabelAddRSS.Name = "LabelAddRSS";
            this.LabelAddRSS.Size = new System.Drawing.Size(81, 13);
            this.LabelAddRSS.TabIndex = 20;
            this.LabelAddRSS.Text = "Lägg till ny feed";
            // 
            // LabelListBoxPodcasts
            // 
            this.LabelListBoxPodcasts.AutoSize = true;
            this.LabelListBoxPodcasts.Location = new System.Drawing.Point(23, 206);
            this.LabelListBoxPodcasts.Name = "LabelListBoxPodcasts";
            this.LabelListBoxPodcasts.Size = new System.Drawing.Size(51, 13);
            this.LabelListBoxPodcasts.TabIndex = 21;
            this.LabelListBoxPodcasts.Text = "Podcasts";
            // 
            // lbDownload
            // 
            this.lbDownload.AutoSize = true;
            this.lbDownload.Location = new System.Drawing.Point(133, 297);
            this.lbDownload.Name = "lbDownload";
            this.lbDownload.Size = new System.Drawing.Size(0, 13);
            this.lbDownload.TabIndex = 24;
            // 
            // ButtonPlayPause
            // 
            this.ButtonPlayPause.Location = new System.Drawing.Point(12, 343);
            this.ButtonPlayPause.Name = "ButtonPlayPause";
            this.ButtonPlayPause.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlayPause.TabIndex = 25;
            this.ButtonPlayPause.Text = "Play/Pause";
            this.ButtonPlayPause.UseVisualStyleBackColor = true;
            this.ButtonPlayPause.Visible = false;
            this.ButtonPlayPause.Click += new System.EventHandler(this.ButtonPlayPause_Click);
            // 
            // ButtonQuitMusicPlayback
            // 
            this.ButtonQuitMusicPlayback.Location = new System.Drawing.Point(93, 343);
            this.ButtonQuitMusicPlayback.Name = "ButtonQuitMusicPlayback";
            this.ButtonQuitMusicPlayback.Size = new System.Drawing.Size(75, 23);
            this.ButtonQuitMusicPlayback.TabIndex = 26;
            this.ButtonQuitMusicPlayback.Text = "Avbryt";
            this.ButtonQuitMusicPlayback.UseVisualStyleBackColor = true;
            this.ButtonQuitMusicPlayback.Visible = false;
            this.ButtonQuitMusicPlayback.Click += new System.EventHandler(this.ButtonQuitMusicPlayback_Click);
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
            this.button4.Location = new System.Drawing.Point(340, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // LabelListBoxFeeds
            // 
            this.LabelListBoxFeeds.AutoSize = true;
            this.LabelListBoxFeeds.Location = new System.Drawing.Point(23, 49);
            this.LabelListBoxFeeds.Name = "LabelListBoxFeeds";
            this.LabelListBoxFeeds.Size = new System.Drawing.Size(36, 13);
            this.LabelListBoxFeeds.TabIndex = 29;
            this.LabelListBoxFeeds.Text = "Feeds";
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
            this.LabelManageFeed.Location = new System.Drawing.Point(744, 19);
            this.LabelManageFeed.Name = "LabelManageFeed";
            this.LabelManageFeed.Size = new System.Drawing.Size(59, 13);
            this.LabelManageFeed.TabIndex = 32;
            this.LabelManageFeed.Text = "Ändra feed";
            // 
            // ComboBoxManageFeed
            // 
            this.ComboBoxManageFeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxManageFeed.FormattingEnabled = true;
            this.ComboBoxManageFeed.Location = new System.Drawing.Point(726, 41);
            this.ComboBoxManageFeed.Name = "ComboBoxManageFeed";
            this.ComboBoxManageFeed.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxManageFeed.TabIndex = 33;
            // 
            // TextBoxManageFeedURL
            // 
            this.TextBoxManageFeedURL.Location = new System.Drawing.Point(747, 76);
            this.TextBoxManageFeedURL.Name = "TextBoxManageFeedURL";
            this.TextBoxManageFeedURL.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManageFeedURL.TabIndex = 34;
            // 
            // TextBoxManageFeedName
            // 
            this.TextBoxManageFeedName.Location = new System.Drawing.Point(747, 102);
            this.TextBoxManageFeedName.Name = "TextBoxManageFeedName";
            this.TextBoxManageFeedName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManageFeedName.TabIndex = 35;
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
            // LabelManageCategory
            // 
            this.LabelManageCategory.AutoSize = true;
            this.LabelManageCategory.Location = new System.Drawing.Point(695, 132);
            this.LabelManageCategory.Name = "LabelManageCategory";
            this.LabelManageCategory.Size = new System.Drawing.Size(46, 13);
            this.LabelManageCategory.TabIndex = 39;
            this.LabelManageCategory.Text = "Kategori";
            // 
            // TextBoxManageFeedUpdateInterval
            // 
            this.TextBoxManageFeedUpdateInterval.Location = new System.Drawing.Point(747, 155);
            this.TextBoxManageFeedUpdateInterval.Name = "TextBoxManageFeedUpdateInterval";
            this.TextBoxManageFeedUpdateInterval.Size = new System.Drawing.Size(100, 20);
            this.TextBoxManageFeedUpdateInterval.TabIndex = 40;
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
            // ButtonManageFeedOk
            // 
            this.ButtonManageFeedOk.Location = new System.Drawing.Point(772, 181);
            this.ButtonManageFeedOk.Name = "ButtonManageFeedOk";
            this.ButtonManageFeedOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonManageFeedOk.TabIndex = 42;
            this.ButtonManageFeedOk.Text = "OK";
            this.ButtonManageFeedOk.UseVisualStyleBackColor = true;
            this.ButtonManageFeedOk.Click += new System.EventHandler(this.ButtonManageFeeds_Click);
            // 
            // LabelManageCategoriesAdd
            // 
            this.LabelManageCategoriesAdd.AutoSize = true;
            this.LabelManageCategoriesAdd.Location = new System.Drawing.Point(393, 343);
            this.LabelManageCategoriesAdd.Name = "LabelManageCategoriesAdd";
            this.LabelManageCategoriesAdd.Size = new System.Drawing.Size(84, 13);
            this.LabelManageCategoriesAdd.TabIndex = 52;
            this.LabelManageCategoriesAdd.Text = "Lägg till kategori";
            // 
            // LabelManageCategoriesChoice
            // 
            this.LabelManageCategoriesChoice.AutoSize = true;
            this.LabelManageCategoriesChoice.Location = new System.Drawing.Point(412, 256);
            this.LabelManageCategoriesChoice.Name = "LabelManageCategoriesChoice";
            this.LabelManageCategoriesChoice.Size = new System.Drawing.Size(65, 13);
            this.LabelManageCategoriesChoice.TabIndex = 51;
            this.LabelManageCategoriesChoice.Text = "Välj kategori";
            // 
            // ButtonManageCategoriesRemove
            // 
            this.ButtonManageCategoriesRemove.Location = new System.Drawing.Point(627, 253);
            this.ButtonManageCategoriesRemove.Name = "ButtonManageCategoriesRemove";
            this.ButtonManageCategoriesRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonManageCategoriesRemove.TabIndex = 49;
            this.ButtonManageCategoriesRemove.Text = "Ta bort";
            this.ButtonManageCategoriesRemove.UseVisualStyleBackColor = true;
            this.ButtonManageCategoriesRemove.Click += new System.EventHandler(this.ButtonManageCategoriesRemove_Click);
            // 
            // TextBoxAddCategory
            // 
            this.TextBoxAddCategory.Location = new System.Drawing.Point(483, 340);
            this.TextBoxAddCategory.Name = "TextBoxAddCategory";
            this.TextBoxAddCategory.Size = new System.Drawing.Size(121, 20);
            this.TextBoxAddCategory.TabIndex = 48;
            // 
            // ButtonManageCategoriesCreate
            // 
            this.ButtonManageCategoriesCreate.Location = new System.Drawing.Point(627, 340);
            this.ButtonManageCategoriesCreate.Name = "ButtonManageCategoriesCreate";
            this.ButtonManageCategoriesCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonManageCategoriesCreate.TabIndex = 47;
            this.ButtonManageCategoriesCreate.Text = "Skapa";
            this.ButtonManageCategoriesCreate.UseVisualStyleBackColor = true;
            this.ButtonManageCategoriesCreate.Click += new System.EventHandler(this.ButtonManageCategoriesCreate_Click);
            // 
            // ComboBoxManageCategories
            // 
            this.ComboBoxManageCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxManageCategories.FormattingEnabled = true;
            this.ComboBoxManageCategories.Location = new System.Drawing.Point(483, 253);
            this.ComboBoxManageCategories.Name = "ComboBoxManageCategories";
            this.ComboBoxManageCategories.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxManageCategories.TabIndex = 46;
            // 
            // ButtonManageCategoriesSave
            // 
            this.ButtonManageCategoriesSave.Location = new System.Drawing.Point(627, 291);
            this.ButtonManageCategoriesSave.Name = "ButtonManageCategoriesSave";
            this.ButtonManageCategoriesSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonManageCategoriesSave.TabIndex = 45;
            this.ButtonManageCategoriesSave.Text = "Spara";
            this.ButtonManageCategoriesSave.UseVisualStyleBackColor = true;
            this.ButtonManageCategoriesSave.Click += new System.EventHandler(this.ButtonManageCategoriesSave_Click);
            // 
            // TextBoxManageCategoriesNewName
            // 
            this.TextBoxManageCategoriesNewName.AccessibleName = "";
            this.TextBoxManageCategoriesNewName.Location = new System.Drawing.Point(483, 291);
            this.TextBoxManageCategoriesNewName.Name = "TextBoxManageCategoriesNewName";
            this.TextBoxManageCategoriesNewName.Size = new System.Drawing.Size(121, 20);
            this.TextBoxManageCategoriesNewName.TabIndex = 44;
            // 
            // LabelManageCategoriesNewName
            // 
            this.LabelManageCategoriesNewName.AutoSize = true;
            this.LabelManageCategoriesNewName.Location = new System.Drawing.Point(422, 296);
            this.LabelManageCategoriesNewName.Name = "LabelManageCategoriesNewName";
            this.LabelManageCategoriesNewName.Size = new System.Drawing.Size(55, 13);
            this.LabelManageCategoriesNewName.TabIndex = 43;
            this.LabelManageCategoriesNewName.Text = "Nytt namn";
            // 
            // LabelManageCategories
            // 
            this.LabelManageCategories.AutoSize = true;
            this.LabelManageCategories.Location = new System.Drawing.Point(479, 222);
            this.LabelManageCategories.Name = "LabelManageCategories";
            this.LabelManageCategories.Size = new System.Drawing.Size(96, 13);
            this.LabelManageCategories.TabIndex = 53;
            this.LabelManageCategories.Text = "Hantera Kategorier";
            // 
            // ButtonManageFeedRemove
            // 
            this.ButtonManageFeedRemove.Location = new System.Drawing.Point(690, 181);
            this.ButtonManageFeedRemove.Name = "ButtonManageFeedRemove";
            this.ButtonManageFeedRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonManageFeedRemove.TabIndex = 54;
            this.ButtonManageFeedRemove.Text = "Ta bort";
            this.ButtonManageFeedRemove.UseVisualStyleBackColor = true;
            this.ButtonManageFeedRemove.Click += new System.EventHandler(this.ButtonManageFeedRemove_Click);
            // 
            // cbChangeFeedCategory
            // 
            this.cbChangeFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeFeedCategory.FormattingEnabled = true;
            this.cbChangeFeedCategory.Location = new System.Drawing.Point(747, 132);
            this.cbChangeFeedCategory.Name = "cbChangeFeedCategory";
            this.cbChangeFeedCategory.Size = new System.Drawing.Size(100, 21);
            this.cbChangeFeedCategory.TabIndex = 55;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 424);
            this.Controls.Add(this.cbChangeFeedCategory);
            this.Controls.Add(this.ButtonManageFeedRemove);
            this.Controls.Add(this.LabelManageCategories);
            this.Controls.Add(this.LabelManageCategoriesAdd);
            this.Controls.Add(this.LabelManageCategoriesChoice);
            this.Controls.Add(this.ButtonManageCategoriesRemove);
            this.Controls.Add(this.TextBoxAddCategory);
            this.Controls.Add(this.ButtonManageCategoriesCreate);
            this.Controls.Add(this.ComboBoxManageCategories);
            this.Controls.Add(this.ButtonManageCategoriesSave);
            this.Controls.Add(this.TextBoxManageCategoriesNewName);
            this.Controls.Add(this.LabelManageCategoriesNewName);
            this.Controls.Add(this.ButtonManageFeedOk);
            this.Controls.Add(this.LabelManageUpdateInterval);
            this.Controls.Add(this.TextBoxManageFeedUpdateInterval);
            this.Controls.Add(this.LabelManageCategory);
            this.Controls.Add(this.LabelManageName);
            this.Controls.Add(this.LabelManageURL);
            this.Controls.Add(this.TextBoxManageFeedName);
            this.Controls.Add(this.TextBoxManageFeedURL);
            this.Controls.Add(this.ComboBoxManageFeed);
            this.Controls.Add(this.LabelManageFeed);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ListBoxFeeds);
            this.Controls.Add(this.LabelListBoxFeeds);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbNowPlaying);
            this.Controls.Add(this.ButtonQuitMusicPlayback);
            this.Controls.Add(this.ButtonPlayPause);
            this.Controls.Add(this.lbDownload);
            this.Controls.Add(this.LabelListBoxPodcasts);
            this.Controls.Add(this.LabelAddRSS);
            this.Controls.Add(this.LabelAddRSSName);
            this.Controls.Add(this.TextBoxAddRSSName);
            this.Controls.Add(this.ButtonAddRSS);
            this.Controls.Add(this.TextBoxAddRSSIntervall);
            this.Controls.Add(this.LabelAddRSSUpdateInterval);
            this.Controls.Add(this.LabelAddRSSCategory);
            this.Controls.Add(this.ComboBoxAddRSS);
            this.Controls.Add(this.LabelAddRSSURL);
            this.Controls.Add(this.TextBoxAddRSSURL);
            this.Controls.Add(this.ButtonShowMore);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListBoxPodcasts);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.ListBox ListBoxPodcasts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonShowMore;
        private System.Windows.Forms.Label LabelAddRSSName;
        private System.Windows.Forms.TextBox TextBoxAddRSSName;
        private System.Windows.Forms.Button ButtonAddRSS;
        private System.Windows.Forms.TextBox TextBoxAddRSSIntervall;
        private System.Windows.Forms.Label LabelAddRSSUpdateInterval;
        private System.Windows.Forms.Label LabelAddRSSCategory;
        private System.Windows.Forms.ComboBox ComboBoxAddRSS;
        private System.Windows.Forms.Label LabelAddRSSURL;
        private System.Windows.Forms.TextBox TextBoxAddRSSURL;
        private System.Windows.Forms.Label LabelAddRSS;
        private System.Windows.Forms.Label LabelListBoxPodcasts;
        private System.Windows.Forms.Label lbDownload;
        private System.Windows.Forms.Button ButtonPlayPause;
        private System.Windows.Forms.Button ButtonQuitMusicPlayback;
        private System.Windows.Forms.Label lbNowPlaying;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LabelListBoxFeeds;
        private System.Windows.Forms.ListBox ListBoxFeeds;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label LabelManageFeed;
        private System.Windows.Forms.ComboBox ComboBoxManageFeed;
        private System.Windows.Forms.TextBox TextBoxManageFeedURL;
        private System.Windows.Forms.TextBox TextBoxManageFeedName;
        private System.Windows.Forms.Label LabelManageURL;
        private System.Windows.Forms.Label LabelManageName;
        private System.Windows.Forms.Label LabelManageCategory;
        private System.Windows.Forms.TextBox TextBoxManageFeedUpdateInterval;
        private System.Windows.Forms.Label LabelManageUpdateInterval;
        private System.Windows.Forms.Button ButtonManageFeedOk;
        private System.Windows.Forms.Label LabelManageCategoriesAdd;
        private System.Windows.Forms.Label LabelManageCategoriesChoice;
        private System.Windows.Forms.Button ButtonManageCategoriesRemove;
        private System.Windows.Forms.TextBox TextBoxAddCategory;
        private System.Windows.Forms.Button ButtonManageCategoriesCreate;
        private System.Windows.Forms.ComboBox ComboBoxManageCategories;
        private System.Windows.Forms.Button ButtonManageCategoriesSave;
        private System.Windows.Forms.TextBox TextBoxManageCategoriesNewName;
        private System.Windows.Forms.Label LabelManageCategoriesNewName;
        private System.Windows.Forms.Label LabelManageCategories;
        private System.Windows.Forms.Button ButtonManageFeedRemove;
        private System.Windows.Forms.ComboBox cbChangeFeedCategory;
    }
}

