namespace Gruppprojekt
{
    partial class add_feed_form
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntervall = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.AccessibleName = "tb_url";
            this.tbURL.Location = new System.Drawing.Point(184, 35);
            this.tbURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(211, 26);
            this.tbURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(216, 92);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(180, 28);
            this.cbCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intervall";
            // 
            // tbIntervall
            // 
            this.tbIntervall.Location = new System.Drawing.Point(248, 172);
            this.tbIntervall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIntervall.Name = "tbIntervall";
            this.tbIntervall.Size = new System.Drawing.Size(148, 26);
            this.tbIntervall.TabIndex = 5;
            this.tbIntervall.Text = "00.00";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "bt_add_ok";
            this.button1.Location = new System.Drawing.Point(393, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "bt_add_cancel";
            this.button2.Location = new System.Drawing.Point(45, 378);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(248, 214);
            this.tbNamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(148, 26);
            this.tbNamn.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Namn";
            // 
            // add_feed_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbIntervall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbURL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "add_feed_form";
            this.Text = "add_feed_form";
        //    ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntervall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.Label label4;
    }
}