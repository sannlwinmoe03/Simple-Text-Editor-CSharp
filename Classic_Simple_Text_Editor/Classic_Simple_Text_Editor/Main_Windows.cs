using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Classic_Simple_Text_Editor
{
    public partial class frmMain_Windows : Form
    {     
        classic_simple_text_editorTableAdapters.File_TypeTableAdapter obft = new classic_simple_text_editorTableAdapters.File_TypeTableAdapter();
        classic_simple_text_editorTableAdapters.KeywordsTableAdapter ojkey = new classic_simple_text_editorTableAdapters.KeywordsTableAdapter();
        classic_simple_text_editorTableAdapters.File_TableTableAdapter ojFtable = new classic_simple_text_editorTableAdapters.File_TableTableAdapter();
        DataTable dtkey = new DataTable();
        DataTable dttype = new DataTable();
        DataTable dtP = new DataTable();
        classic_simple_text_editorTableAdapters.PreferenceTableAdapter Pf = new classic_simple_text_editorTableAdapters.PreferenceTableAdapter();
       
        public frmMain_Windows()
        {
            InitializeComponent();
        }
            private void CreateFile_Click(object sender, EventArgs e)
        {
            frmMain_Windows MaW = new frmMain_Windows();
            MaW.Show();
        }

        private void File_Click(object sender, EventArgs e)
        {

        
     
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog open = new OpenFileDialog();
            open.RestoreDirectory = true;
            open.InitialDirectory = "D:";
            open.Title = "open file";
            open.FileName = "New Document.txt";
            open.Filter = "Text files(*.txt,*.doc,*.docx,*.pdf)|*.txt;*.doc;*.pdf|All files(*.*)|*.*";
            if (open.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    FileStream FS = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader SRR = new StreamReader(FS);
                    string line = SRR.ReadLine();
                    while (line != null)
                    {
                        rtb.Text += line + "\n";
                        line = SRR.ReadLine();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again. Something Wrong");
                }
            }                  
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefd = new SaveFileDialog();
            savefd.RestoreDirectory = true;
            savefd.InitialDirectory = "D:/Simple_Text_Editor_Program/Filefolder/";
            savefd.Title = "open file";
            savefd.FileName = "New Document.txt";
            savefd.Filter = "Text files(*.txt,*.doc,*.pdf)|*.txt;*.doc,*.rtf,*.pdf|All files(*.*)|*.*";

            if (savefd.ShowDialog() == DialogResult.OK)
            {
                string path = "D:/Simple_Text_Editor_Program/" + savefd.FileName;
                try
                {
                    FileStream fs = new FileStream(savefd.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(fs);


                    sw.WriteLine(rtb.Text);





                    ojFtable.FiletableInsertQuery(txtfileID.Text, savefd.FileName, path, cbofiletype.Text, lblID.Text);
                    MessageBox.Show("Save Successful", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);





                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong in file processing", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    private void Close_Click(object sender, EventArgs e)
        {
         
        }

        private void ExitFile_Click(object sender, EventArgs e)
        {
           
        }

        private void Main_Windows_Load(object sender, EventArgs e)
        {
            txthandlerID.Text = frmLoginhandler.HandlerLogName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Windows_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            RichTextBox objrtb = new RichTextBox();
            objrtb.Text = objrtb.Text.Replace(txtfind.Text, txtreplace.Text);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
                RichTextBox objrtb = new RichTextBox();
                String SearchKeyword = txtsearch.Text;
                MatchCollection keywordMarches = Regex.Matches(objrtb.Text, SearchKeyword);

                int o_Line = objrtb.SelectionStart;
                int o_length = objrtb.SelectionLength;
                objrtb.SelectionStart = 0;
                objrtb.SelectionLength = objrtb.Text.Length;

                foreach (Match M in keywordMarches)
                {


                    objrtb.SelectionStart = M.Index;
                    objrtb.SelectionLength = M.Length;
                    objrtb.SelectionColor = objrtb.BackColor;
                    objrtb.SelectionBackColor = Color.AliceBlue;
                }
           
            }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        public void Highlight()
        {
            Varkeywords var = new Varkeywords();
            var.ColumnGetSet = "";
            DataTable dtkey = new DataTable();
            dtkey = ojkey.GetData();
            
            for (int x = 0; x < dtkey.Rows.Count ; x++)
            {
                string[] keywords = { dtkey.Rows[x]["Kaywords"].ToString() };


                foreach (string item in keywords)
                {
                    var.ColumnGetSet += item + "|";
                }
                Regex R = new Regex(var.ColumnGetSet);
                int index = rtb.SelectionStart;
                foreach (Match m in R.Matches(rtb.Text))
                {
                    rtb.Select(m.Index, m.Value.Length);
                    rtb.SelectionColor = Color.Blue;                    
                }
                rtb.SelectionStart = index;               
            }
            rtb.SelectionColor = Color.Black;
        }

        public void Dark()
        {  
              rtb.ForeColor = Color.White;         
           rtb.BackColor = Color.Black;


        }
        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnzoomin_Click_1(object sender, EventArgs e)
        {

            float currentSize;
            currentSize = rtb.Font.Size;
            currentSize += 2.0F;
            rtb.Font = new Font(rtb.Font.Name, currentSize, rtb.Font.Style, rtb.Font.Unit);
        }

        private void btnzoomout_Click_1(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = rtb.Font.Size;
            currentSize -= 2.0F;
            rtb.Font = new Font(rtb.Font.Name, currentSize, rtb.Font.Style, rtb.Font.Unit);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            Highlight();
            bracketmatching();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear(); 
        }

        private void btngo_Click_1(object sender, EventArgs e)
        {            
            rtb.Text = rtb.Text.Replace(txtfind.Text, txtreplace.Text);
        }

        public void find()
        {
            String find_word = txtfind.Text;
            MatchCollection findwordmatch = Regex.Matches(rtb.Text, find_word);
            int wordline = rtb.SelectionStart;
            int wordlength = rtb.SelectionLength;
            rtb.SelectionStart = 0;
            rtb.SelectionStart = rtb.Text.Length;
            foreach (Match m in findwordmatch)
            {
                rtb.SelectionStart = m.Index;
                rtb.SelectionLength = m.Length;
                rtb.SelectionBackColor = Color.Red;
            }
        }
        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                RichTextBox objrtb = new RichTextBox();
                String SearchKeyword = txtsearch.Text;
                MatchCollection keywordMarches = Regex.Matches(objrtb.Text, SearchKeyword);

                int o_Line = objrtb.SelectionStart;
                int o_length = objrtb.SelectionLength;
                objrtb.SelectionStart = 0;
                objrtb.SelectionLength = objrtb.Text.Length;

                foreach (Match M in keywordMarches)
                {


                    objrtb.SelectionStart = M.Index;
                    objrtb.SelectionLength = M.Length;
                    objrtb.SelectionColor = objrtb.BackColor;
                    objrtb.SelectionBackColor = Color.AliceBlue;
                }
            }
            catch
            {
                MessageBox.Show("Enter the text");
            }


        }

        private void txtfind_TextChanged_1(object sender, EventArgs e)
        {
            find();
        }

        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string special = e.KeyChar.ToString();
            int selectionchar = rtb.SelectionStart;
            if (special == "(")
            {
                rtb.Text = rtb.Text.Insert(selectionchar, "(" + "\n" + ")");
                e.Handled = true;
                rtb.SelectionStart = selectionchar + 1;
            }
            else if (special == "{")
            {
                string s = "{" + "\n" + "}";
                rtb.Text = rtb.Text.Insert(selectionchar, s);
                e.Handled = true;
                rtb.SelectionStart = selectionchar + s.Length - 1;
            }
            else if (special == "[")
            {
                rtb.Text = rtb.Text.Insert(selectionchar, "[" + "\n" + "]");
                e.Handled = true;
              rtb.SelectionStart = selectionchar + 1;
            }
            else if (special == "<")
            {
                rtb.Text = rtb.Text.Insert(selectionchar, "<" + "\n" + ">");
                e.Handled = true;
                rtb.SelectionStart = selectionchar + 1;
            }
            else if (special == "\\")
            {
                rtb.Text = rtb.Text.Insert(selectionchar, "\\");
                e.Handled = true;
                rtb.SelectionStart = selectionchar + 1;
            }
            else if (special == "'")
            {
                rtb.Text = rtb.Text.Insert(selectionchar, "'" + "\n" + "'");
                e.Handled = true;
                rtb.SelectionStart = selectionchar + 1;
            }
            Highlight();            
        }

        private void alignLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AutoFileID()
        {
            
           
                int Row = Convert.ToInt32(ojFtable.numberIDScalarQuery());
                if (Row <= 0)
                {
                    txtfileID.Text = "F001";
                }
                else
                {
                    Row = Row + 1;
                    txtfileID.Text = "F00" + Row;
                }
            
            
           
            
          
        }

        private void frmMain_Windows_Load(object sender, EventArgs e)
        {
            AutoFileID();
            Membertypedata(); AutoFileTypeID();
        }
        public void bracketmatching()
        {

            Highlight();
            int insertionPoint = rtb.SelectionStart;
 if (rtb.Find("[", insertionPoint,insertionPoint + 1, RichTextBoxFinds.MatchCase) == insertionPoint)
            {
                rtb.SelectionBackColor = Color.Blue;
                while (insertionPoint <=rtb.TextLength)
                {
                    rtb.Find("]", insertionPoint,
                rtb.TextLength, RichTextBoxFinds.MatchCase);
                    rtb.SelectionBackColor = Color.Blue;
                    break;
                }
            }
           else if (rtb.Find("{", insertionPoint,insertionPoint + 1, RichTextBoxFinds.MatchCase) == insertionPoint)
            {
                rtb.SelectionBackColor = Color.Blue;
                while (insertionPoint <= rtb.TextLength)
                {
                    rtb.Find("}", insertionPoint,
                rtb.TextLength, RichTextBoxFinds.MatchCase);
                    rtb.SelectionBackColor = Color.Blue;
                    break;
                }
            }

            else if (rtb.Find("<", insertionPoint, insertionPoint + 1, RichTextBoxFinds.MatchCase) == insertionPoint)
            {
                rtb.SelectionBackColor = Color.Blue;
                while (insertionPoint <= rtb.TextLength)
                {
                    rtb.Find(">", insertionPoint,
                rtb.TextLength, RichTextBoxFinds.MatchCase);
                    rtb.SelectionBackColor = Color.Blue;
                    break;
                }
            }

            else if (rtb.Find("(", insertionPoint,insertionPoint + 1, RichTextBoxFinds.MatchCase) == insertionPoint)
            {
                rtb.SelectionBackColor = Color.Blue;
                while (insertionPoint <= rtb.TextLength)
                {
                    rtb.Find(")", insertionPoint,
                rtb.TextLength, RichTextBoxFinds.MatchCase);
                    rtb.SelectionBackColor = Color.Blue;
                    break;
                }
            }

        }

        private void csharpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Highlight();
        }

        private void topToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.SelectionStart = 0;
            rtb.ScrollToCaret();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void alignCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult FontResult = fd.ShowDialog();
            if (FontResult==DialogResult.OK)
            {
                rtb.SelectionFont = fd.Font;
            }
        }

        private void downToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font bfont = new Font(rtb.Font, FontStyle.Bold);
            Font rfont = new Font(rtb.Font, FontStyle.Regular);

            if (rtb.SelectedText.Length == 0)
                return;
            if (rtb.SelectionFont.Bold)
            {
                rtb.SelectionFont = rfont;
            }
            else
            {
                rtb.SelectionFont = bfont;
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font Ifont = new Font(rtb.Font, FontStyle.Italic);
            Font rfont = new Font(rtb.Font, FontStyle.Regular);

            if (rtb.SelectedText.Length == 0)
                return;
            if (rtb.SelectionFont.Italic)
            {
                rtb.SelectionFont = rfont;
            }
            else            
            {
                rtb.SelectionFont = Ifont;
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font Ufont = new Font(rtb.Font, FontStyle.Underline);
            Font rfont = new Font(rtb.Font, FontStyle.Regular);

            if (rtb.SelectedText.Length == 0)
                return;
            if (rtb.SelectionFont.Underline)
            {
                rtb.SelectionFont = rfont;    
            }
            else {
                rtb.SelectionFont = Ufont;
            }
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font Sfont = new Font(rtb.Font, FontStyle.Strikeout);
            Font rfont = new Font(rtb.Font, FontStyle.Regular);


            if (rtb.SelectedText.Length == 0)
                return;
            if (rtb.SelectionFont.Strikeout)
            {
                rtb.SelectionFont = rfont;
            }
            else
            {
                rtb.SelectionFont = Sfont;
                }
        }

        private void ExitFile_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbofiletype_SelectedIndexChanged(object sender, EventArgs e)
        {
            dttype = obft.GetDataBy1(cbofiletype.SelectedItem.ToString());
            lblID.Text = dttype.Rows[0].ToString();
           
        }
        public void Membertypedata()
        {
            dttype = obft.GetData();
            for (int j = 0; j < dttype.Rows.Count; j++)
            {
                cbofiletype.Items.Add(dttype.Rows[j][1].ToString());
            }
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dark();
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtfileID_TextChanged(object sender, EventArgs e)
        {
            AutoFileID();
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            AutoFileTypeID();
        }
        private void AutoFileTypeID()
        {

            int Count = Convert.ToInt32(obft.FTIDScalarQuery());
            if (Count <= 0)
            {
                txtfileID.Text = "Ft001";
            }
            else
            {
                Count = Count + 1;
                txtfileID.Text = "Ft00" + Count;
            }

        }
    }
}
