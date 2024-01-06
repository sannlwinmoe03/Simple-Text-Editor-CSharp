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
    public partial class frmLoginhandler : Form
    {
        public static String HandlerLogID = null;
        public static String HandlerLogName = null;
        classic_simple_text_editorTableAdapters.handler1TableAdapter objhandler = new classic_simple_text_editorTableAdapters.handler1TableAdapter();

        public frmLoginhandler()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtlogemail.Text == "")
            {
                MessageBox.Show("Please Enter Your Email");
            }
            else if (txtlogpassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password ");
            }
            else
            {
                string email = txtlogemail.Text;
                string password = txtlogpassword.Text;
               int logincount = Convert.ToInt32(objhandler.handlerScalarQuery(txtlogemail.Text, txtlogpassword.Text));

                if (logincount == 0)
                {
                    MessageBox.Show("Can't Login");
                    txtlogemail.Text = "";
                   txtlogpassword.Text = "";
                }
                else
                {
                    DataTable dtHandler = new DataTable();
                    dtHandler = objhandler.GetDataBy3(email, password);
                    HandlerLogID = dtHandler.Rows[0]["UserID"].ToString();
                    HandlerLogName = dtHandler.Rows[0]["UserName"].ToString();


                    MessageBox.Show("Success Login");
                    frmMain_Windows MaW = new frmMain_Windows();
                    MaW.Show();
                    this.Hide();
                   
                }
                
            }
        }
        
        private void btntoregister_Click(object sender, EventArgs e)
        {
           FrmHandleroption HaO = new FrmHandleroption();
            HaO.Show();
            this.Hide();

        }

        private void Loginhandler_Load(object sender, EventArgs e)
        {

        }

        private void btmback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
