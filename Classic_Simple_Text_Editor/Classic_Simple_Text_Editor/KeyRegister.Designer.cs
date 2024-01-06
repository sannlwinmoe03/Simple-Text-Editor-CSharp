namespace Classic_Simple_Text_Editor
{
    partial class s
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
            this.components = new System.ComponentModel.Container();
            this.lblkeyID = new System.Windows.Forms.Label();
            this.lblkeyname = new System.Windows.Forms.Label();
            this.lblkeytype = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnkeysave = new System.Windows.Forms.Button();
            this.btnkeycancel = new System.Windows.Forms.Button();
            this.classicsimpletexteditorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classic_simple_text__editorDataSet = new Classic_Simple_Text_Editor.classic_simple_text__editorDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.classicsimpletexteditorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classic_simple_text__editorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkeyID
            // 
            this.lblkeyID.AutoSize = true;
            this.lblkeyID.Location = new System.Drawing.Point(125, 48);
            this.lblkeyID.Name = "lblkeyID";
            this.lblkeyID.Size = new System.Drawing.Size(86, 17);
            this.lblkeyID.TabIndex = 0;
            this.lblkeyID.Text = "Keywords ID";
            // 
            // lblkeyname
            // 
            this.lblkeyname.AutoSize = true;
            this.lblkeyname.Location = new System.Drawing.Point(125, 108);
            this.lblkeyname.Name = "lblkeyname";
            this.lblkeyname.Size = new System.Drawing.Size(110, 17);
            this.lblkeyname.TabIndex = 1;
            this.lblkeyname.Text = "Keywords Name";
            this.lblkeyname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblkeytype
            // 
            this.lblkeytype.AutoSize = true;
            this.lblkeytype.Location = new System.Drawing.Point(125, 175);
            this.lblkeytype.Name = "lblkeytype";
            this.lblkeytype.Size = new System.Drawing.Size(105, 17);
            this.lblkeytype.TabIndex = 2;
            this.lblkeytype.Text = "Keywords Type";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(306, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(306, 103);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(306, 169);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 5;
            // 
            // btnkeysave
            // 
            this.btnkeysave.Location = new System.Drawing.Point(128, 231);
            this.btnkeysave.Name = "btnkeysave";
            this.btnkeysave.Size = new System.Drawing.Size(75, 23);
            this.btnkeysave.TabIndex = 6;
            this.btnkeysave.Text = "&Save";
            this.btnkeysave.UseVisualStyleBackColor = true;
            this.btnkeysave.Click += new System.EventHandler(this.btnkeysave_Click);
            // 
            // btnkeycancel
            // 
            this.btnkeycancel.Location = new System.Drawing.Point(331, 231);
            this.btnkeycancel.Name = "btnkeycancel";
            this.btnkeycancel.Size = new System.Drawing.Size(75, 23);
            this.btnkeycancel.TabIndex = 7;
            this.btnkeycancel.Text = "Cancel";
            this.btnkeycancel.UseVisualStyleBackColor = true;
            // 
            // classicsimpletexteditorDataSetBindingSource
            // 
            this.classicsimpletexteditorDataSetBindingSource.DataSource = this.classic_simple_text__editorDataSet;
            this.classicsimpletexteditorDataSetBindingSource.Position = 0;
            // 
            // classic_simple_text__editorDataSet
            // 
            this.classic_simple_text__editorDataSet.DataSetName = "classic_simple_text__editorDataSet";
            this.classic_simple_text__editorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 332);
            this.Controls.Add(this.btnkeycancel);
            this.Controls.Add(this.btnkeysave);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblkeytype);
            this.Controls.Add(this.lblkeyname);
            this.Controls.Add(this.lblkeyID);
            this.Name = "s";
            this.Text = "KeyRegister";
            ((System.ComponentModel.ISupportInitialize)(this.classicsimpletexteditorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classic_simple_text__editorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkeyID;
        private System.Windows.Forms.Label lblkeyname;
        private System.Windows.Forms.Label lblkeytype;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnkeysave;
        private System.Windows.Forms.Button btnkeycancel;
        private System.Windows.Forms.BindingSource classicsimpletexteditorDataSetBindingSource;
        private classic_simple_text__editorDataSet classic_simple_text__editorDataSet;
    }
}