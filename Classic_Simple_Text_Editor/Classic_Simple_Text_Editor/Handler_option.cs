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
    public partial class FrmHandleroption : Form
    {
        classic_simple_text_editorTableAdapters.handler1TableAdapter objhandler = new classic_simple_text_editorTableAdapters.handler1TableAdapter();
        public FrmHandleroption()
        {
            InitializeComponent();
        }

        private void Handler_option_Load(object sender, EventArgs e)
        {
            AutoID();
        }
        private void AutoID()
        {
            int RowCount = Convert.ToInt32(objhandler.numberofmember());
            if (RowCount <= 0)
            {
                lblboxID.Text = "M001";
            }
            else
            {
                RowCount = RowCount + 1;
                lblboxID.Text = "M00" + RowCount;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string Gender;
            if (rdomale.Checked == true)
            {
                Gender = rdomale.Text;
            }
            else
            {
                Gender = rdofemale.Text;
            }
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please Enter Your Name First");
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please Enter Your Email First");
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password First");
            }
            else if (txtnrc.Text == "")
            {
                MessageBox.Show("Please Enter Your NRC First");
            }
            else if (rdomale.Checked == false && rdofemale.Checked == false)
            {
                MessageBox.Show("Please Enter Your Gender");
            }
            else
            {

                objhandler.handlerInsertQuery(txtusername.Text, lblboxID.Text, txtemail.Text, txtpassword.Text, txtnrc.Text, Gender);

                frmLoginhandler LiH = new frmLoginhandler();
                LiH.Show();
                this.Hide();

            }
        }
        private void policycheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmLoginhandler LiH = new frmLoginhandler();
            LiH.Show();
            this.Hide();
        }

        private void lblboxID_Click(object sender, EventArgs e)
        {

        }

        private void policycheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            btnregister.Enabled = true;
        }
    }
}
