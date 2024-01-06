namespace Classic_Simple_Text_Editor
{
    partial class frmMain_Windows
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblfind = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lblreplace = new System.Windows.Forms.Label();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.txthandlerID = new System.Windows.Forms.TextBox();
            this.btnzoomin = new System.Windows.Forms.Button();
            this.btnzoomout = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.cbofiletype = new System.Windows.Forms.ComboBox();
            this.txtfileID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.ExitFile,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1089, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.White;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFile,
            this.OpenFile,
            this.Save,
            this.Close});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(44, 24);
            this.File.Text = "File";
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // CreateFile
            // 
            this.CreateFile.BackColor = System.Drawing.Color.White;
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateFile.Size = new System.Drawing.Size(257, 26);
            this.CreateFile.Text = " Create a New File";
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.White;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFile.Size = new System.Drawing.Size(257, 26);
            this.OpenFile.Text = "Open File";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(257, 26);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.White;
            this.Close.Name = "Close";
            this.Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Close.Size = new System.Drawing.Size(257, 26);
            this.Close.Text = "&Close";
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // ExitFile
            // 
            this.ExitFile.BackColor = System.Drawing.Color.White;
            this.ExitFile.Name = "ExitFile";
            this.ExitFile.Size = new System.Drawing.Size(45, 24);
            this.ExitFile.Text = "&Exit";
            this.ExitFile.Click += new System.EventHandler(this.ExitFile_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.downToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.alignLeftToolStripMenuItem,
            this.alignRightToolStripMenuItem,
            this.alignCentreToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikethroughToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.topToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click_1);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.downToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click_1);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click_1);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click_1);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click_1);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click_1);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click_1);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // alignLeftToolStripMenuItem
            // 
            this.alignLeftToolStripMenuItem.AutoSize = false;
            this.alignLeftToolStripMenuItem.Name = "alignLeftToolStripMenuItem";
            this.alignLeftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.alignLeftToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.alignLeftToolStripMenuItem.Text = "Align Left";
            this.alignLeftToolStripMenuItem.Click += new System.EventHandler(this.alignLeftToolStripMenuItem_Click);
            // 
            // alignRightToolStripMenuItem
            // 
            this.alignRightToolStripMenuItem.Name = "alignRightToolStripMenuItem";
            this.alignRightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.alignRightToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.alignRightToolStripMenuItem.Text = "Align Right";
            this.alignRightToolStripMenuItem.Click += new System.EventHandler(this.alignRightToolStripMenuItem_Click);
            // 
            // alignCentreToolStripMenuItem
            // 
            this.alignCentreToolStripMenuItem.Name = "alignCentreToolStripMenuItem";
            this.alignCentreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.alignCentreToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.alignCentreToolStripMenuItem.Text = "Align Centre";
            this.alignCentreToolStripMenuItem.Click += new System.EventHandler(this.alignCentreToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikethroughToolStripMenuItem
            // 
            this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.strikethroughToolStripMenuItem.Text = "Strikethrough";
            this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.strikethroughToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.preferenceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click_1);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem});
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.preferenceToolStripMenuItem.Text = "Preference";
            this.preferenceToolStripMenuItem.Click += new System.EventHandler(this.preferenceToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(465, 4);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(53, 17);
            this.lblsearch.TabIndex = 3;
            this.lblsearch.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(524, 5);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 22);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged_1);
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(667, 4);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(35, 17);
            this.lblfind.TabIndex = 5;
            this.lblfind.Text = "Find";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(708, 5);
            this.txtfind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(100, 22);
            this.txtfind.TabIndex = 6;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged_1);
            // 
            // lblreplace
            // 
            this.lblreplace.AutoSize = true;
            this.lblreplace.Location = new System.Drawing.Point(830, 6);
            this.lblreplace.Name = "lblreplace";
            this.lblreplace.Size = new System.Drawing.Size(60, 17);
            this.lblreplace.TabIndex = 7;
            this.lblreplace.Text = "Replace";
            // 
            // txtreplace
            // 
            this.txtreplace.Location = new System.Drawing.Point(896, 6);
            this.txtreplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(100, 22);
            this.txtreplace.TabIndex = 8;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(1002, 5);
            this.btngo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 23);
            this.btngo.TabIndex = 10;
            this.btngo.Text = "GO";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click_1);
            // 
            // txthandlerID
            // 
            this.txthandlerID.Location = new System.Drawing.Point(359, 5);
            this.txthandlerID.Name = "txthandlerID";
            this.txthandlerID.Size = new System.Drawing.Size(100, 22);
            this.txthandlerID.TabIndex = 11;
            // 
            // btnzoomin
            // 
            this.btnzoomin.Location = new System.Drawing.Point(908, 429);
            this.btnzoomin.Name = "btnzoomin";
            this.btnzoomin.Size = new System.Drawing.Size(75, 23);
            this.btnzoomin.TabIndex = 12;
            this.btnzoomin.Text = "Zoom In";
            this.btnzoomin.UseVisualStyleBackColor = true;
            this.btnzoomin.Click += new System.EventHandler(this.btnzoomin_Click_1);
            // 
            // btnzoomout
            // 
            this.btnzoomout.Location = new System.Drawing.Point(989, 429);
            this.btnzoomout.Name = "btnzoomout";
            this.btnzoomout.Size = new System.Drawing.Size(88, 23);
            this.btnzoomout.TabIndex = 13;
            this.btnzoomout.Text = "Zoom Out";
            this.btnzoomout.UseVisualStyleBackColor = true;
            this.btnzoomout.Click += new System.EventHandler(this.btnzoomout_Click_1);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 34);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(1065, 389);
            this.rtb.TabIndex = 14;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            this.rtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_KeyPress);
            // 
            // cbofiletype
            // 
            this.cbofiletype.FormattingEnabled = true;
            this.cbofiletype.Location = new System.Drawing.Point(232, 6);
            this.cbofiletype.Name = "cbofiletype";
            this.cbofiletype.Size = new System.Drawing.Size(121, 24);
            this.cbofiletype.TabIndex = 15;
            this.cbofiletype.SelectedIndexChanged += new System.EventHandler(this.cbofiletype_SelectedIndexChanged);
            // 
            // txtfileID
            // 
            this.txtfileID.Location = new System.Drawing.Point(13, 429);
            this.txtfileID.Name = "txtfileID";
            this.txtfileID.Size = new System.Drawing.Size(100, 22);
            this.txtfileID.TabIndex = 16;
            this.txtfileID.Visible = false;
            this.txtfileID.TextChanged += new System.EventHandler(this.txtfileID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(120, 429);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 17;
            this.lblID.Visible = false;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // frmMain_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtfileID);
            this.Controls.Add(this.cbofiletype);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnzoomout);
            this.Controls.Add(this.btnzoomin);
            this.Controls.Add(this.txthandlerID);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.lblreplace);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.lblfind);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain_Windows";
            this.Text = "Main Windows";
            this.Load += new System.EventHandler(this.frmMain_Windows_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem CreateFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem ExitFile;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lblreplace;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.TextBox txthandlerID;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Button btnzoomin;
        private System.Windows.Forms.Button btnzoomout;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbofiletype;
        private System.Windows.Forms.TextBox txtfileID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
    }
}