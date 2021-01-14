using Remittances.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class Add_Remit : Form
    {
        commissaryClass cmssryClass = new commissaryClass();
        CountryClass cntryClass = new CountryClass();
        currencyClass currncyClass = new currencyClass();

        int sMandoopID, rMandoopID, rCountryID, sCountryID;
        string sMandoop, rMandoop, sCountry, rCountry;
        public Add_Remit()
        {
            InitializeComponent();

            cmboCommissaryBIND();
            cmbo_R_commissaryBIND();

            cmboCountry_SBIND();           

            cmboCountry_RBIND();

            cmboCurrencyBIND();

            cmboRemitState.SelectedIndex = 0;
            cmboRemitType.SelectedIndex = 0;

            GetKassRate();
            GetAmountUSD();
            change_country_OR_currency();
            txtNote_Prepare();
        }
        void cmboCommissaryBIND()
        {
            cmbo_S_commissary.DataSource = cmssryClass.get_all_commissaries();
            cmbo_S_commissary.DisplayMember = "commissary_name";
            cmbo_S_commissary.ValueMember = "commissaryID";
        }
        void cmbo_R_commissaryBIND()
        {
            cmbo_R_commissary.DataSource = cmssryClass.get_all_commissaries();
            cmbo_R_commissary.DisplayMember = "commissary_name";
            cmbo_R_commissary.ValueMember = "commissaryID";
            cmbo_R_commissary.SelectedIndex = 2;
        }
        void cmboCountry_SBIND()
        {
            cmboCountry_S.DataSource = cntryClass.get_all_countries();
            cmboCountry_S.DisplayMember = "countryName";
            cmboCountry_S.ValueMember = "countryID";
            cmboCountry_S.SelectedIndex = 5;
        }
        void cmboCountry_RBIND()
        {
            cmboCountry_R.DataSource = cntryClass.get_all_countries();
            cmboCountry_R.DisplayMember = "countryName";
            cmboCountry_R.ValueMember = "countryID";
        }
        void cmboCurrencyBIND()
        {
            cmboCurrency.DataSource = cntryClass.get_all_countries();
            cmboCurrency.DisplayMember = "currency";
            cmboCurrency.ValueMember = "countryID";
            cmboCurrency.SelectedIndex = cmboCountry_S.SelectedIndex;
        }        
        private void CmboCommissary_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNote_Prepare();
        }
        private void Cmbo_R_commissary_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNote_Prepare();
        }
        private void CmboCountry_S_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmboCurrency.SelectedIndex = cmboCountry_S.SelectedIndex;
            change_country_OR_currency();
        }
        private void CmboCurrency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmboCountry_S.SelectedIndex = cmboCurrency.SelectedIndex;
            change_country_OR_currency();
        }
        private void change_country_OR_currency()
        {
            GetKassRate();
            GetAmountUSD();
            GetCommission();
            GetAmountDLV();
            lblCurrency.Text = cmboCurrency.GetItemText(cmboCurrency.SelectedItem);
            txtNote_Prepare();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            GetCommission();
            GetAmountDLV();
        }
        void GetKassRate()
        {
            // جلب سعر القص
            string rIndex = cmboCurrency.GetItemText(cmboCurrency.SelectedItem);
            DataTable dt = currncyClass.get_KassRate(rIndex);
            txtKassRate.Text = dt.Rows[0][0].ToString();
        }
        void GetAmountUSD()
        {
            //جلب المبلغ بالدولار
            if(txtKassRate.Text !=string.Empty & txtAmount.Text != string.Empty)
            {
                txtAmountUSD.Text = (1 / Convert.ToDouble(txtKassRate.Text) * Convert.ToDouble(txtAmount.Text)).ToString("0.00");
            }
        }
        void GetAmountDLV()
        {
            //جلب مبلغ التسليم
            if (txtKassRate.Text != string.Empty & txtAmount.Text != string.Empty)
            {
                txtAmountDLV.Text = (1 / Convert.ToDouble(txtKassRate.Text) * Convert.ToDouble(txtAmount.Text)).ToString("0.00");
            }
        }
        void GetCommission()
        {
            //جلب العمولة
            if (txtAmountUSD.Text != string.Empty)
            {
                {
                    txtCommission.Text = (Convert.ToDouble(txtAmountUSD.Text) * 0.035 + 10).ToString("0");                    
                }
            }
        }
        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            GetAmountUSD();
        }
        //private int GetCommissaryID()
        //{
        //    string mandoopName = cmboCommissary.GetItemText(cmboCommissary.SelectedItem);
        //    mandoopID = Convert.ToInt32(cmssryClass.get_Curr_commissary(mandoopName).Rows[0][0].ToString());
        //    return mandoopID;
        //}

        //private int Get_S_CountryID()
        //{
        //    string sCountry = cmboCountry_S.GetItemText(cmboCountry_S.SelectedItem);
        //    sCountryID = Convert.ToInt32(cntryClass.get_countryID(sCountry).Rows[0][0].ToString());
        //    return sCountryID;
        //}
        //private int Get_R_CountryID()
        //{
        //    string rCountry = cmboCountry_R.GetItemText(cmboCountry_R.SelectedItem);
        //    rCountryID = Convert.ToInt32(cntryClass.get_countryID(rCountry).Rows[0][0].ToString());
        //    return rCountryID;
        //}
        private void btnAddRemit_Click(object sender, EventArgs e)
        {
            Add_The_Remit();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSender.Text = "mandoop";
        }
        private void Add_The_Remit()
        {
            RemitClass remitCls = new RemitClass();
            sMandoopID = Convert.ToInt32(cmbo_S_commissary.SelectedValue.ToString());
            rMandoopID = Convert.ToInt32(cmbo_R_commissary.SelectedValue.ToString());
            sCountryID = Convert.ToInt32(cmboCountry_S.SelectedValue.ToString());
            rCountryID = Convert.ToInt32(cmboCountry_R.SelectedValue.ToString());
            //string sDate =dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            try
            {
                remitCls.Adding_Remit(
                    cmboRemitType.Text,
                    sMandoopID, 
                    rMandoopID,
                    sCountryID,
                    dateTimePicker1.Value,
                    rCountryID,
                    Convert.ToSingle(txtAmount.Text),
                    Convert.ToSingle(txtKassRate.Text),
                    Convert.ToSingle(txtAmountDLV.Text),
                    Convert.ToSingle(txtCost.Text),
                    Convert.ToSingle(txtCommission.Text),
                    cmboCurrency.GetItemText(cmboCurrency.SelectedItem),
                    txtSender.Text,
                    txtRecipient.Text,
                    cmboRemitState.Text,
                    txtNote.Text
                    );
                change_sMandoop_Account();
                change_rMandoop_Account();
                Clear_All();                
                MessageBox.Show("تمت اضافة الحوالة بنجاح", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "في الغالب هناك بعض الحقول الضرورية قد تركتها فارغة" + Environment.NewLine + "..املأ الحقول جميعاً..", ":حصل الخطأ التالي" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void change_sMandoop_Account()
        {
            sMandoopID = Convert.ToInt32(cmbo_S_commissary.SelectedValue.ToString());
            float mandoopAcc=Convert.ToSingle(txtAmount.Text);
            cmssryClass.changeMandopAcc(sMandoopID, mandoopAcc);
        }
        private void change_rMandoop_Account()
        {
            rMandoopID = Convert.ToInt32(cmbo_R_commissary.SelectedValue.ToString());
            float mandoopAcc = Convert.ToSingle(txtAmountDLV.Text);
            cmssryClass.changeMandopAcc(rMandoopID, - mandoopAcc);
        }
        private void Clear_All()
        {
            cmboRemitState.SelectedIndex = 0;
            cmboRemitType.SelectedIndex = 0;
            txtSender.Text = string.Empty;
            txtRecipient.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtAmountUSD.Text = string.Empty;
            txtAmountDLV.Text = string.Empty;
            txtCost.Text = string.Empty;
            txtCommission.Text = string.Empty;
        }
        private void txtNote_Prepare()
        {
            rMandoop = cmbo_R_commissary.GetItemText(cmbo_R_commissary.SelectedItem);
            sMandoop = cmbo_S_commissary.GetItemText(cmbo_S_commissary.SelectedItem);
            sCountry = cmboCountry_S.GetItemText(cmboCountry_S.SelectedItem);
            rCountry = cmboCountry_R.GetItemText(cmboCountry_R.SelectedItem);
            txtNote.Text = " من (" + sMandoop + ") في " + sCountry + "-- تم الترحيل الى (" + rMandoop + ") لتسليمها في " + rCountry;
        }
    }
}
