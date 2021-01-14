using Remittances.Models;
using System;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class FRM_Users : Form
    {
        LoginClass clsLogin = new LoginClass();
        public FRM_Users()
        {
            //LoginClass clsLogin = new LoginClass();
            InitializeComponent();
            DGV_Users.DataSource = clsLogin.Search_User("");
            //DG_Users.Columns["pwd"].Visible = false; // the index of pwd =1
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FRM_Add_User frmS = new FRM_Add_User();
            frmS.Text = "إضافة مستخدم جديد";            
            frmS.ShowDialog();
            DGV_Users.DataSource = clsLogin.Search_User("");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FRM_Add_User frmS = new FRM_Add_User();
            frmS.btnAddUser.Text = "تعديل المستخدم";
            frmS.Text = "تعديل مستخدم ";
            frmS.txtUserID.Text = DGV_Users.CurrentRow.Cells[0].Value.ToString();
            frmS.txtPWD.Text = DGV_Users.CurrentRow.Cells[1].Value.ToString();
            frmS.txtPWD_Confirm.Text = DGV_Users.CurrentRow.Cells[1].Value.ToString();
            frmS.txtFullName.Text = DGV_Users.CurrentRow.Cells[2].Value.ToString();
            frmS.CmbUsers.Text = DGV_Users.CurrentRow.Cells[3].Value.ToString();

            //LoginClass clsLogin = new LoginClass();
            frmS.ShowDialog();
            DGV_Users.DataSource = clsLogin.Search_User("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            //LoginClass clsLogin = new LoginClass();
            DGV_Users.DataSource = clsLogin.Search_User(txtSearchUser.Text);

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            //LoginClass clsLogin = new LoginClass();
            if (MessageBox.Show("هل تريد حذف المستخدم المحدد؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string uFullname = DGV_Users.CurrentRow.Cells[1].Value.ToString(); //for Entries

                clsLogin.Delete_User(DGV_Users.CurrentRow.Cells[0].Value.ToString());
                //for Entries
                Program.entryCls.Add_Entry("حذف مستخدم من البرنامج", uFullname, Program.Salesman, DateTime.Now);

                DGV_Users.DataSource = clsLogin.Search_User("");
            }
        }
    }
}
