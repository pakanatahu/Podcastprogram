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
            this.ShowMoreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowMoreTextBox
            // 
            this.ShowMoreTextBox.Location = new System.Drawing.Point(26, 28);
            this.ShowMoreTextBox.Multiline = true;
            this.ShowMoreTextBox.Name = "ShowMoreTextBox";
            this.ShowMoreTextBox.ReadOnly = true;
            this.ShowMoreTextBox.Size = new System.Drawing.Size(380, 277);
            this.ShowMoreTextBox.TabIndex = 0;
            // 
            // ShowMorePodcastInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 340);
            this.Controls.Add(this.ShowMoreTextBox);
            this.Name = "ShowMorePodcastInfo";
            this.Text = "ShowMorePodcastInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowMoreTextBox;
    }
}