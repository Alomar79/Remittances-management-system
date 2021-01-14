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
    public partial class frmAddCountry : Form
    {
        public string state = "Add";
        CountryClass cntryCls = new CountryClass();
        currencyClass crrncyClass = new currencyClass();
        public frmAddCountry()
        {
            InitializeComponent();
            cmboCurrency_BIND();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            
            if (state == "Add")
            {                
                if (cmboCurrency.Text == string.Empty)
                {
                    MessageBox.Show("يجب تحديد العملة من القائمة", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtCountryName.Text != string.Empty )
                {
                    cntryCls.Add_Country(txtCountryName.Text, cmboCurrency.Text);
                    MessageBox.Show(" تمت اضافة البلد ( " + txtCountryName.Text + " ) بنجاح  ", "اضافة بلد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //for Entries
                    Program.entryCls.Add_Entry("اضافة بلد", txtCountryName.Text, Program.Salesman, DateTime.Now);

                    clearAll_Cntry();
                }
                else
                    MessageBox.Show("املأ الحقول الفارغة الضرورية - اسم البلد  ", "حقول فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (state == "Update")
            {
                cntryCls.Edit_Country(Convert.ToInt32(txtCountryID.Text), txtCountryName.Text, cmboCurrency.Text);
                MessageBox.Show(" تم تعديل بيانات البلد ( " + txtCountryID.Text + " ) بنجاح  ", "تعديل بلد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //for Entries
                Program.entryCls.Add_Entry("تعديل بيانات بلد", txtCountryName.Text, Program.Salesman, DateTime.Now);

                clearAll_Cntry();
            }
            frmCountries.getMainForm.PrepareDataGV_Countries();
            //clearAll_Cntry();
        }
        
        public void clearAll_Cntry()
        {
            txtCountryID.Clear();            
            txtCountryName.Clear();
            //cmboCurrency.Text=null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            clearAll_Cntry();
            Close();
        }
        public void cmboCurrency_BIND()
        {
            this.cmboCurrency.DataSource = crrncyClass.get_all_currencies();
            this.cmboCurrency.DisplayMember = "currency_name";
            this.cmboCurrency.ValueMember = "id";
            //cmboCurrency.SelectedIndex = 5;
        }

    }
}
