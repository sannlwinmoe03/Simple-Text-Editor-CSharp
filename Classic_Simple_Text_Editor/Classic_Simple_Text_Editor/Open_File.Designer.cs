namespace Classic_Simple_Text_Editor
{
    partial class Open_File
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
            this.RTBtext = new System.Windows.Forms.RichTextBox();
            this.OFDfilebox = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // RTBtext
            // 
            this.RTBtext.Location = new System.Drawing.Point(12, 12);
            this.RTBtext.Name = "RTBtext";
            this.RTBtext.Size = new System.Drawing.Size(773, 318);
            this.RTBtext.TabIndex = 0;
            this.RTBtext.Text = "";
            // 
            // OFDfilebox
            // 
            this.OFDfilebox.FileName = "openFileDialog1";
            this.OFDfilebox.FileOk += new System.ComponentModel.CancelEventHandler(this.OFDfilebox_FileOk);
            // 
            // Open_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 342);
            this.Controls.Add(this.RTBtext);
            this.Name = "Open_File";
            this.Text = "Open_File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBtext;
        private System.Windows.Forms.OpenFileDialog OFDfilebox;
    }
}