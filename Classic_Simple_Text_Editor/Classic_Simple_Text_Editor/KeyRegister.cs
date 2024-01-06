using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Simple_Text_Editor
{
    
    public partial class s : Form
    {
        classic_simple_text_editorTableAdapters.KeywordsTableAdapter Ktb = new classic_simple_text_editorTableAdapters.KeywordsTableAdapter();
        public s()
        {
            InitializeComponent();
        }
        private void AutoID()
        {
            int RowCount = Convert.ToInt32(Ktb.KeyIDScalarQuery());
            if (RowCount <= 0)
            {
                txtID.Text = "K001";
            }
            else
            {
                RowCount = RowCount + 1;
               txtID.Text = "M00" + RowCount;
            }
        }

        private void btnkeysave_Click(object sender, EventArgs e)
        {
            Ktb.KeywordsInsertQuery(txtID.Text, txtname.Text, txtType.Text);
            txtType.Clear();
            txtname.Clear();
            txtID.Clear();
        }
    }
}
