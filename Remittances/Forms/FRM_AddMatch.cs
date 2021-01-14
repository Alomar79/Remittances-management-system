using Remittances.Models;
using System;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class FRM_AddMatch : Form
    {
        private readonly AccountClass accCls = new AccountClass();
        private readonly currencyClass crrncyCls = new currencyClass();
        public FRM_AddMatch()
        {
            InitializeComponent();
            Prepare_cmbo_Account();
            Prepare_cmbo_currency();
        }
        void Prepare_cmbo_Account()
        {
            cmbo_Account.DataSource = accCls.get_all_Accounts();
            cmbo_Account.DisplayMember = "acc_id";
            cmbo_Account.ValueMember = "name";
        }
        void Prepare_cmbo_currency()
        {
            cmbo_currency.DataSource = crrncyCls.get_all_currencies();
            cmbo_currency.DisplayMember = "currency_name";
            cmbo_currency.ValueMember = "currency_code";
        }
        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            string AccountID = cmbo_Account.GetItemText(cmbo_Account.SelectedItem);
            string crrncyName = cmbo_currency.GetItemText(cmbo_currency.SelectedItem);
            if (AccountID == string.Empty)
            {
                MessageBox.Show("اختر من لائحة الحسابات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AccountID == string.Empty || crrncyName == string.Empty || txtCreditor.Text == string.Empty || txtDeptor.Text == string.Empty)
            {
                MessageBox.Show("جميع الحقول مطلوبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            MatchClass matchCls = new MatchClass();

            if (btnAddMatch.Text == "حفظ المطابقة")
            {
                matchCls.Add_Match(AccountID, crrncyName, Convert.ToSingle(txtCreditor.Text), Convert.ToSingle(txtDeptor.Text), Convert.ToDateTime(dtm_mDate.Text), txtMnote.Text);

                MessageBox.Show("تمت اضافة المطابقة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //for Entries
                Program.entryCls.Add_Entry("اضافة مطابقة", AccountID, Program.Salesman, DateTime.Now);
            }

            else if (btnAddMatch.Text == "تعديل المطابقة")
            {
                matchCls.Edit_Match(Convert.ToInt32(txtMatchID.Text), AccountID, crrncyName, Convert.ToSingle(txtCreditor.Text), Convert.ToSingle(txtDeptor.Text), Convert.ToDateTime(dtm_mDate.Text), txtMnote.Text);
                MessageBox.Show("تم نعديل المطابقة", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //for Entries
                Program.entryCls.Add_Entry("تعديل بيانات مطابقة", AccountID, Program.Salesman, DateTime.Now);

                frmMatches frmMtchs = new frmMatches();
                frmMtchs.PrepareDataGV_Matches();
                frmMtchs.Dispose();
            }
            cleartexts();
        }
        public void cleartexts()
        {
            txtMatchID.Clear();
            cmbo_Account.Text = null;
            cmbo_currency.Text = null;
            txtCreditor.Clear();
            txtDeptor.Clear();
            dtm_mDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtMnote.Clear();
            lbl_dontChange.Visible = false;
            cmbo_Account.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //char.IsDigit(e.KeyChar) :  يسمح بالارقام فقط
        //e.KeyChar != 8   :  يسمح بالحذف
        //e.KeyChar!=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator) :  يسمح بالفاصلة العشرية
        private void TxtCreditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalCeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalCeperator)
            {
                e.Handled = true;
            }
        }
        private void TxtDeptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalCeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalCeperator)
            {
                e.Handled = true;
            }
        }
    }
}
    
