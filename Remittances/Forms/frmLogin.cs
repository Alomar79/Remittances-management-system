using Remittances.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class frmLogin : Form
    {
        private LoginClass log = new LoginClass();

        public frmLogin()
        {            
            InitializeComponent();
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess clsDA = new DataAccess();
            DataTable dt = log.login(txtUserName.Text, txtPassword.Text);

            if (dt.Rows.Count > 0)
            {
                Program.Salesman = dt.Rows[0]["fullname"].ToString();
                //for Entries
                Program.entryCls.Add_Entry("تسجيل دخول الى البرنامج", dt.Rows[0]["user_id"].ToString() , Program.Salesman, DateTime.Now);

                this.Close();
            }

            else
                MessageBox.Show("إما اسم المستخدم أو كلمة السر خاطئة، أعد المحاولة أو أغلق البرنامج", "تنبيه", MessageBoxButtons.OK,MessageBoxIcon.Warning);            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //for Entries
            Program.entryCls.Add_Entry("تسجيل خروج من البرنامج", "-", Program.Salesman, DateTime.Now);
            Application.Exit();
        }
        
        private void TxtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }

        }

        private void TxtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.Focus();
        }

    }
}
