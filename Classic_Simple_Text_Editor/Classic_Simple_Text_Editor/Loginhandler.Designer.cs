namespace Classic_Simple_Text_Editor
{
    partial class frmLoginhandler
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
            this.lblname = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btmback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlogemail = new System.Windows.Forms.TextBox();
            this.txtlogpassword = new System.Windows.Forms.TextBox();
            this.btntoregister = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(255, 26);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(331, 73);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Classic Text Editor";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.Location = new System.Drawing.Point(199, 346);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 28);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btmback
            // 
            this.btmback.Location = new System.Drawing.Point(525, 345);
            this.btmback.Margin = new System.Windows.Forms.Padding(4);
            this.btmback.Name = "btmback";
            this.btmback.Size = new System.Drawing.Size(100, 28);
            this.btmback.TabIndex = 2;
            this.btmback.Text = "Exit";
            this.btmback.UseVisualStyleBackColor = true;
            this.btmback.Click += new System.EventHandler(this.btmback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtlogemail
            // 
            this.txtlogemail.Location = new System.Drawing.Point(395, 114);
            this.txtlogemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogemail.Name = "txtlogemail";
            this.txtlogemail.Size = new System.Drawing.Size(229, 22);
            this.txtlogemail.TabIndex = 5;
            // 
            // txtlogpassword
            // 
            this.txtlogpassword.Location = new System.Drawing.Point(395, 198);
            this.txtlogpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogpassword.Name = "txtlogpassword";
            this.txtlogpassword.PasswordChar = '*';
            this.txtlogpassword.Size = new System.Drawing.Size(229, 22);
            this.txtlogpassword.TabIndex = 6;
            // 
            // btntoregister
            // 
            this.btntoregister.BackColor = System.Drawing.Color.Transparent;
            this.btntoregister.Location = new System.Drawing.Point(321, 302);
            this.btntoregister.Margin = new System.Windows.Forms.Padding(4);
            this.btntoregister.Name = "btntoregister";
            this.btntoregister.Size = new System.Drawing.Size(165, 28);
            this.btntoregister.TabIndex = 7;
            this.btntoregister.Text = "Create New Account";
            this.btntoregister.UseVisualStyleBackColor = false;
            this.btntoregister.Click += new System.EventHandler(this.btntoregister_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 398);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // frmLoginhandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Classic_Simple_Text_Editor.Properties.Resources.w;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 398);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btntoregister);
            this.Controls.Add(this.txtlogpassword);
            this.Controls.Add(this.txtlogemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmback);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginhandler";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Loginhandler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btmback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlogemail;
        private System.Windows.Forms.TextBox txtlogpassword;
        private System.Windows.Forms.Button btntoregister;
        private System.Windows.Forms.Splitter splitter1;
    }
}