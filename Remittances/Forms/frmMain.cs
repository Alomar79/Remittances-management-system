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
    public partial class frmMain : Form
    {

        public frmMain()
        {            
            InitializeComponent();
            cleanEntryLogs();

            frmLogin frmLog = new frmLogin();
            frmLog.ShowDialog();
            if( !string.IsNullOrEmpty(Program.Salesman))
            {
                lblWelcome1.Text =   "  مرحباً سيد  ";
                lblWelcome2.Text = Program.Salesman;
            }
                
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TSMImanageUseres_Click(object sender, EventArgs e)
        {
            FRM_Users frmUsers = new FRM_Users();
            frmUsers.ShowDialog();
        }

        private void TSMIaddUser_Click(object sender, EventArgs e)
        {
            FRM_Add_User frmAddUser = new FRM_Add_User();
            frmAddUser.ShowDialog();
        }

        private void TSMILogOut_Click(object sender, EventArgs e)
        {
            DialogResult DRes = MessageBox.Show("أنت على وشك الخروج من البرنامج، هل تريد الخروج فعلاً ؟","تـحـذيـر",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(DRes== DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void TMSIaddRemit_Click(object sender, EventArgs e)
        {
            Add_Remit frmAddRemit = new Add_Remit();
            frmAddRemit.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void TSMImanageAcc_Click(object sender, EventArgs e)
        {
            FRM_Accounts frmAcc = new FRM_Accounts();
            frmAcc.Show();
        }

        private void TSMIaddAcc_Click(object sender, EventArgs e)
        {
            frmAddAcc frmAdd = new frmAddAcc();
            frmAdd.Show();
        }

        private void TSMIprogEntries_Click(object sender, EventArgs e)
        {
            frmEntriesProg frmEntryP = new frmEntriesProg();
            frmEntryP.Show();
        }

        private void TSMIqueryAcc_Click(object sender, EventArgs e)
        {

        }

        private void TSMIaddCountry_Click(object sender, EventArgs e)
        {
            frmAddCountry frmAddCntry = new frmAddCountry();
            frmAddCntry.Show();
        }

        private void TSMIcontryConfig_Click(object sender, EventArgs e)
        {
            frmCountries frmContrs = new frmCountries();
            frmContrs.Show();
        }

        private void TSMIcurrencySetting_Click(object sender, EventArgs e)
        {            
            frmCurrency frmcrrncs = new frmCurrency();
            frmcrrncs.Show();
        }

        private void TSMIaddCurrency_Click(object sender, EventArgs e)
        {
            frmAddCurrency frmAddcrrncy = new frmAddCurrency();
            frmAddcrrncy.Show();
        }

        private void TSMImakeBackup_Click(object sender, EventArgs e)
        {

        }

        void cleanEntryLogs()
        {
            if (DateTime.Now.ToString("dd MMMM") == "15 January" ||
                DateTime.Now.ToString("dd MMMM") == "15 March" ||
                DateTime.Now.ToString("dd MMMM") == "15 May" ||
                DateTime.Now.ToString("dd MMMM") == "15 July" ||
                DateTime.Now.ToString("dd MMMM") == "25 September" ||
                DateTime.Now.ToString("dd MMMM") == "15 November" )
            {
                Program.entryCls.Delete_Logins_Entry("تسجيل دخول الى البرنامج");

                Program.entryCls.Delete_Logins_Entry("حذف عملة");
                Program.entryCls.Delete_Logins_Entry("تعديل بيانات العملة");

                Program.entryCls.Delete_Logins_Entry("حذف بلد");

                Program.entryCls.Delete_Logins_Entry("تعديل بيانات بلد");

                Program.entryCls.Delete_Logins_Entry("تعديل في بيانات حساب");
                

            }
        }

        private void TSMI_manageCustomer_Click(object sender, EventArgs e)
        {
            FRM_Customers frmCstmr = new FRM_Customers();
            frmCstmr.ShowDialog();
        }

        private void TSMI_addCustomer_Click(object sender, EventArgs e)
        {
            FRM_AddCustomer frmAddCstmr = new FRM_AddCustomer();
            frmAddCstmr.ShowDialog();
        }

        private void TSMI_CustomerQuery_Click(object sender, EventArgs e)
        {

        }

        private void MTSI_MatchesManage_Click(object sender, EventArgs e)
        {
            frmMatches frmMtchs = new frmMatches();
            frmMtchs.Show();
        }
    }
}
