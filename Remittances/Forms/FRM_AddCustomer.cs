using Remittances.Models;
using System;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class FRM_AddCustomer : Form
    {
        FRM_Customers frmCstmrs = new FRM_Customers();
        private CustomerClass cstmrClass = new CustomerClass();
        public FRM_AddCustomer()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if( txtFullname.Text == string.Empty ||txtCountry.Text == string.Empty)
            {
                MessageBox.Show("املأ الحقول مطلوبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnAddCustomer.Text == "حفظ الزبون")
            {
                cstmrClass.Add_Customer(txtFullname.Text, txtNationalID.Text, txtCountry.Text, txtMobil.Text, txtNotes.Text);
                MessageBox.Show("تمت اضافة الزبون", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(btnAddCustomer.Text == "تعديل الزبون")
            {
                cstmrClass.Edit_Customer(Convert.ToInt32(txtCustomerID.Text), txtFullname.Text, txtNationalID.Text, txtCountry.Text, txtMobil.Text, txtNotes.Text);
                MessageBox.Show("تم نعديل الزبون", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frmCstmrs.DGV_Customers.DataSource = cstmrClass.SearchCustomer("");
                frmCstmrs.PrepareDataGV_Customers();
            }
            ClearTexts();
            //clear texts
            void ClearTexts()
            {
                txtCustomerID.Clear();
                txtCountry.Clear();
                txtFullname.Clear();
                txtNationalID.Clear();
                txtMobil.Clear();
                txtNotes.Clear();
                txtFullname.Focus();
            }
        }

       
    }
}
