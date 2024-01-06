namespace Classic_Simple_Text_Editor
{
    partial class FrmHandleroption
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtnrc = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblnrc = new System.Windows.Forms.Label();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.btnregister = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblboxID = new System.Windows.Forms.Label();
            this.policycheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(284, 44);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(132, 22);
            this.txtusername.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(284, 90);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(132, 22);
            this.txtemail.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(284, 142);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(132, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // txtnrc
            // 
            this.txtnrc.Location = new System.Drawing.Point(284, 192);
            this.txtnrc.Margin = new System.Windows.Forms.Padding(4);
            this.txtnrc.Name = "txtnrc";
            this.txtnrc.Size = new System.Drawing.Size(132, 22);
            this.txtnrc.TabIndex = 3;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblusername.Location = new System.Drawing.Point(99, 52);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(73, 17);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Username";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblemail.Location = new System.Drawing.Point(99, 98);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 17);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpassword.Location = new System.Drawing.Point(99, 150);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(69, 17);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Password";
            // 
            // lblnrc
            // 
            this.lblnrc.AutoSize = true;
            this.lblnrc.BackColor = System.Drawing.Color.Transparent;
            this.lblnrc.Location = new System.Drawing.Point(103, 199);
            this.lblnrc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnrc.Name = "lblnrc";
            this.lblnrc.Size = new System.Drawing.Size(37, 17);
            this.lblnrc.TabIndex = 8;
            this.lblnrc.Text = "NRC";
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.BackColor = System.Drawing.Color.Transparent;
            this.rdomale.Location = new System.Drawing.Point(107, 255);
            this.rdomale.Margin = new System.Windows.Forms.Padding(4);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(59, 21);
            this.rdomale.TabIndex = 9;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = false;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.BackColor = System.Drawing.Color.Transparent;
            this.rdofemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdofemale.Location = new System.Drawing.Point(284, 255);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(75, 21);
            this.rdofemale.TabIndex = 10;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = false;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.Enabled = false;
            this.btnregister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnregister.Location = new System.Drawing.Point(67, 358);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(100, 28);
            this.btnregister.TabIndex = 11;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancel.Location = new System.Drawing.Point(240, 357);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 28);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblboxID
            // 
            this.lblboxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblboxID.Location = new System.Drawing.Point(583, 39);
            this.lblboxID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblboxID.Name = "lblboxID";
            this.lblboxID.Size = new System.Drawing.Size(133, 28);
            this.lblboxID.TabIndex = 13;
            this.lblboxID.Visible = false;
            this.lblboxID.Click += new System.EventHandler(this.lblboxID_Click);
            // 
            // policycheckBox
            // 
            this.policycheckBox.AutoSize = true;
            this.policycheckBox.BackColor = System.Drawing.Color.Transparent;
            this.policycheckBox.Location = new System.Drawing.Point(67, 308);
            this.policycheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.policycheckBox.Name = "policycheckBox";
            this.policycheckBox.Size = new System.Drawing.Size(190, 21);
            this.policycheckBox.TabIndex = 14;
            this.policycheckBox.Text = "I accept terms and policy.";
            this.policycheckBox.UseVisualStyleBackColor = false;
            this.policycheckBox.CheckedChanged += new System.EventHandler(this.policycheckBox_CheckedChanged_1);
            // 
            // FrmHandleroption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Classic_Simple_Text_Editor.Properties.Resources.book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 414);
            this.Controls.Add(this.policycheckBox);
            this.Controls.Add(this.lblboxID);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.lblnrc);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtnrc);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHandleroption";
            this.Text = "Handleroption";
            this.Load += new System.EventHandler(this.Handler_option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtnrc;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblnrc;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblboxID;
        private System.Windows.Forms.CheckBox policycheckBox;
    }
}