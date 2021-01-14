using Remittances.Models;
using System;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class FRM_Customers : Form
    {
        CustomerClass cstmrClass = new CustomerClass();
        public FRM_Customers()
        {
            InitializeComponent();
            //DGV_Customers.DataSource = cstmrClass.SearchCustomer("");
            PrepareDataGV_Customers();
            //DG_Users.Columns["pwd"].Visible = false; // the index of pwd =1
        }
        public void PrepareDataGV_Customers ()
        {
            DGV_Customers.DataSource = cstmrClass.SearchCustomer("");
            DGV_Customers.Columns[0].Visible = false;
            DGV_Customers.Columns[1].HeaderText = "اسم الزبون";
            DGV_Customers.Columns[2].HeaderText = "الرقم الوطنب";
            DGV_Customers.Columns[3].HeaderText = "البلد";
            DGV_Customers.Columns[4].HeaderText = "الهاتف";
            DGV_Customers.Columns[5].HeaderText = "ملاحظة";
            
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FRM_AddCustomer frmS = new FRM_AddCustomer();
            frmS.Text = "إضافة زبون جديد";            
            frmS.ShowDialog();
            DGV_Customers.DataSource = cstmrClass.SearchCustomer("");
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            FRM_AddCustomer frmAddC = new FRM_AddCustomer();
            frmAddC.btnAddCustomer.Text = "تعديل الزبون";
            frmAddC.Text = "تعديل زبون ";
            frmAddC.txtCustomerID.Text = DGV_Customers.CurrentRow.Cells[0].Value.ToString();
            frmAddC.txtFullname.Text = DGV_Customers.CurrentRow.Cells[1].Value.ToString();
            frmAddC.txtNationalID.Text = DGV_Customers.CurrentRow.Cells[2].Value.ToString();
            frmAddC.txtCountry.Text = DGV_Customers.CurrentRow.Cells[3].Value.ToString();
            frmAddC.txtMobil.Text = DGV_Customers.CurrentRow.Cells[4].Value.ToString();
            frmAddC.txtNotes.Text = DGV_Customers.CurrentRow.Cells[5].Value.ToString();

            frmAddC.ShowDialog();
            DGV_Customers.DataSource = cstmrClass.SearchCustomer("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            DGV_Customers.DataSource = cstmrClass.SearchCustomer(txtSearchCustomer.Text);
        }
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الزبون المحدد؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cstmrClass.Delete_Customer(Convert.ToInt32(DGV_Customers.CurrentRow.Cells[0].Value));
                DGV_Customers.DataSource = cstmrClass.SearchCustomer("");
            }
        }
    }
}
