using Remittances.Models;
using System;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class FRM_Add_User : Form
    {
        
        
        public FRM_Add_User()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text==string.Empty || txtPWD.Text == string.Empty ||txtPWD_Confirm.Text == string.Empty ||txtFullName.Text == string.Empty)
            {
                MessageBox.Show("جميع الحقول مطلوبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if(txtPWD.Text != txtPWD_Confirm.Text)
            {
                MessageBox.Show("حقلي كلمة السر غير متطابقين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //FRM_Users frmUsers = new FRM_Users();
            LoginClass clsLogin = new LoginClass();

            if (btnAddUser.Text == "حفظ المستخدم")
            {
                clsLogin.Add_User(txtUserID.Text, txtFullName.Text, txtPWD.Text, CmbUsers.Text);
                MessageBox.Show("تمت اضافة المستخدم", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //for Entries
                Program.entryCls.Add_Entry("اضافة مستخدم للبرنامج", txtFullName.Text, Program.Salesman, DateTime.Now);

            }

            else if(btnAddUser.Text == "تعديل المستخدم")
            {
                clsLogin.Edit_User(txtUserID.Text, txtFullName.Text, txtPWD.Text, CmbUsers.Text);
                MessageBox.Show("تم نعديل المستخدم", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //for Entries
                Program.entryCls.Add_Entry("تعديل بيانات مستخدم للبرنامج", txtFullName.Text, Program.Salesman, DateTime.Now);
            }
            //clear texts
            txtUserID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWD_Confirm.Clear();
            CmbUsers.Text = null;
            txtUserID.Focus();
        }
    }
}
