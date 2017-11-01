namespace Gruppprojekt
{
    partial class ShowMorePodcastInfo
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
            this.TextBoxShowMore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxShowMore
            // 
            this.TextBoxShowMore.Location = new System.Drawing.Point(17, 18);
            this.TextBoxShowMore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxShowMore.Multiline = true;
            this.TextBoxShowMore.Name = "TextBoxShowMore";
            this.TextBoxShowMore.ReadOnly = true;
            this.TextBoxShowMore.Size = new System.Drawing.Size(255, 181);
            this.TextBoxShowMore.TabIndex = 0;
            this.TextBoxShowMore.TabStop = false;
            // 
            // ShowMorePodcastInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 221);
            this.Controls.Add(this.TextBoxShowMore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowMorePodcastInfo";
            this.Text = "ShowMorePodcastInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxShowMore;
    }
}