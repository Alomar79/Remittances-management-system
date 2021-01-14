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
    public partial class frmAddCurrency : Form
    {
        public string state = "Add";
        DataAccess dac = new DataAccess();
        currencyClass crrncyClass = new currencyClass();
        CountryClass cntryCls = new CountryClass();
        public frmAddCurrency()
        {
            InitializeComponent();
            cmboCountry_BIND();
        }

        private void BtnAddCurrency_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                if (txtCurrencyName.Text != string.Empty & txtCntry.Text !=string.Empty
                    & txtCurrencyCode.Text!=string.Empty & txtEx_rateUSD.Text!=string.Empty )
                {
                    float ex = Convert.ToSingle(txtEx_rateUSD.Text);
                    crrncyClass.Add_Currency(txtCurrencyCode.Text, txtCurrencyName.Text, txtCntry.Text, ex);
                    MessageBox.Show(" تمت اضافة العملة  " + Environment.NewLine + txtCurrencyName.Text + Environment.NewLine + "  بنجاح  ", "اضافة عملة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //for Entries
                    Program.entryCls.Add_Entry("اضافة عملة", txtCurrencyName.Text, Program.Salesman, DateTime.Now);
                    clearAll_Curr();
                }
                else
                    MessageBox.Show("املأ الحقول الفارغة الضرورية.  ", "حقول فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (state == "Update")
            {
                if (txtCurrencyName.Text != string.Empty & txtCntry.Text != string.Empty
                    & txtCurrencyCode.Text != string.Empty & txtEx_rateUSD.Text != string.Empty)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    float ex = Convert.ToSingle(txtEx_rateUSD.Text);
                    crrncyClass.Edit_Currency(id, txtCurrencyCode.Text, txtCurrencyName.Text, txtCntry.Text, ex);

                    //for Entries
                    Program.entryCls.Add_Entry("تعديل بيانات العملة", txtCurrencyName.Text, Program.Salesman, DateTime.Now);

                    //// الآن تعديل على جدول البلدان
                    //string cntryName = cmboCountry.GetItemText(cmboCountry.SelectedItem);
                    //int x = Convert.ToInt32(((cntryCls.get_countryID(cntryName)).Rows[0][0]).ToString());
                    //cntryCls.Edit_Country(x, cmboCountry.Text, txtCurrencyName.Text);

                    MessageBox.Show(" تم تعديل بيانات العملة  " + Environment.NewLine + txtCurrencyName.Text + Environment.NewLine + "  بنجاح  ", "تعديل عملة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll_Curr();
                }
                else
                    MessageBox.Show("املأ الحقول الفارغة الضرورية  ", "حقول فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmCurrency.getMainForm.PrepareDataGV_Currencies();
            //clearAll_Curr();
            //state = "Add";
        }
        
        public void clearAll_Curr()
        {
            txtCurrencyCode.Clear();            
            txtCurrencyName.Clear();
            txtEx_rateUSD.Clear();
            txtCntry.Clear();
            txtID.Clear();
            cmboCountry.Text=null;
        }
        public void cmboCountry_BIND()
        {
            cmboCountry.DataSource = cntryCls.get_all_countries();
            cmboCountry.DisplayMember = "country_name";
            cmboCountry.ValueMember = "country_id";
            //cmboCurrency.SelectedIndex = 5;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            state = "Add";
            Close();
        }

        private void CmboCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
             txtCntry.Text= cmboCountry.GetItemText(cmboCountry.SelectedItem);
        }

        private void TxtCntry_TextChanged(object sender, EventArgs e)
        {
            cmboCountry.Text = txtCntry.Text;
        }

        //char.IsDigit(e.KeyChar) :  يسمح بالارقام فقط
        //e.KeyChar != 8   :  يسمح بالحذف
        //e.KeyChar!=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator) :  يسمح بالفاصلة العشرية
        private void TxtEx_rateUSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalCeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalCeperator)
            {
                e.Handled = true;
            }
        }
    }
}
