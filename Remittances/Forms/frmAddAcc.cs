using Remittances.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class frmAddAcc : Form
    {
        public string state = "Add";
        DataAccess dac = new DataAccess();
        AccountClass accCls = new AccountClass();
        public frmAddAcc()
        {
            InitializeComponent();            
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {

                if (cmboAccType.Text == string.Empty)
                {
                    MessageBox.Show("يجب تحديد نوع الحساب من القائمة", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (accCls.get_lastAccountNo().Rows[0][0].ToString() != string.Empty
                    & txtAccName.Text != string.Empty & txtAccCountry.Text != string.Empty)
                {
                    if (txtAccMob.Text == string.Empty) txtAccMob.Text = "0";
                    if (txtAccNote.Text == string.Empty) txtAccNote.Text = "0";

                    int x = 0;
                    switch (cmboAccType.Text)
                    {
                        case "حسابات شركتنا": x = 1; break;
                        case "حساب شركة نتعامل معها": x = 2; break;
                        case "حساب مندوب": x = 3; break;
                        case "حساب زبون عادي": x = 4; break;
                        default: x = 5; break;
                    }
                    string accID = accCls.getAccID(txtAccName.Text, x);

                    accCls.Add_Account(accID, txtAccName.Text, cmboAccType.Text,
                    txtAccCountry.Text, txtAccMob.Text, txtAccNote.Text);
                    MessageBox.Show(" تمت اضافة الحساب ( " + accID + " ) بنجاح  ", "اضافة حساب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //for Entries
                    Program.entryCls.Add_Entry("اضافة حساب جديد", txtAccName.Text, Program.Salesman, DateTime.Now);

                    clearAll_Acc();
                }
                else
                    MessageBox.Show("املأ الحقول الفارغة الضرورية - الاسم والبلد ", "حقول فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (state == "Update")
            {
                accCls.Edit_Account(txtAccID.Text, txtAccName.Text, cmboAccType.Text,
                txtAccCountry.Text, txtAccMob.Text, txtAccNote.Text);
                MessageBox.Show(" تم تعديل الحساب ( " + txtAccID.Text + " ) بنجاح  ", "تعديل حساب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //for Entries
                Program.entryCls.Add_Entry("تعديل في بيانات حساب", txtAccID.Text, Program.Salesman, DateTime.Now);

                clearAll_Acc();
            }
            FRM_Accounts.getMainForm.PrepareDataGV_ACCs();
        }

        private void clearAll_Acc()
        {
            txtAccID.Clear();
            txtAccCountry.Clear();
            txtAccMob.Clear();
            txtAccNote.Clear();
            txtAccName.Clear();
            cmboAccType.Text=null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
