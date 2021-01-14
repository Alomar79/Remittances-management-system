using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Remittances.Models;
using Remittances.Forms;

namespace Remittances.Forms
{
    public partial class frmCurrency : Form
    {
        public string id;
        private CountryClass cntryCls = new CountryClass();
        private currencyClass crrncyClass = new currencyClass();
        private static frmCurrency frmM;
        frmAddCurrency frm = new frmAddCurrency();
        private static void frmM_Formclosed(object sender, FormClosedEventArgs e)
        {
            frmM = null;
        }
        public static frmCurrency getMainForm
        {
            get
            {
                if (frmM == null)
                {
                    frmM = new frmCurrency();
                    frmM.FormClosed += new FormClosedEventHandler(frmM_Formclosed);
                }
                return frmM;
            }
        }
        public frmCurrency()
        {
            InitializeComponent();
            if (frmM == null)
                frmM = this;

            PrepareDataGV_Currencies();
        }
        public void PrepareDataGV_Currencies()
        {
            dataGV_Currencies.DataSource = crrncyClass.get_all_currencies();
            dataGV_Currencies.Columns[0].HeaderText = "id";
            dataGV_Currencies.Columns[1].HeaderText = "كود العملة";
            dataGV_Currencies.Columns[2].HeaderText = "العملة";
            dataGV_Currencies.Columns[3].HeaderText = "البلد";
            dataGV_Currencies.Columns[4].HeaderText = "سعرالدولار";
        }
        private void txtSearchCurrency_TextChanged(object sender, EventArgs e)
        {
            dataGV_Currencies.DataSource = crrncyClass.SearchCurrency(txtSearchCurrency.Text);
        }
        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("did you sure to delete ?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    id = dataGV_ACCs.CurrentRow.Cells[0].Value.ToString();
            //    AccCls.Delete_Product(id);
            //    MessageBox.Show("تمت عملية الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else MessageBox.Show("تم إلغاء عملية الحذف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dataGV_ACCs.DataSource = prd.get_all_products();

        }

        private void btnEditCountry_Click(object sender, EventArgs e)
        {
            //frmAddCountry frm = new frmAddCountry();

            //frm.txtCurrencyID.Visible = true;
            //frm.txtCurrencyID.ReadOnly = true;
            //frm.lblCurrencyID.Visible = true;
            frm.txtID.Text= this.dataGV_Currencies.CurrentRow.Cells[0].Value.ToString();
            frm.txtCurrencyCode.Text = this.dataGV_Currencies.CurrentRow.Cells[1].Value.ToString();
            frm.txtCurrencyName.Text = this.dataGV_Currencies.CurrentRow.Cells[2].Value.ToString();
            frm.cmboCountry_BIND();
            frm.cmboCountry.Text = this.dataGV_Currencies.CurrentRow.Cells[3].Value.ToString();
            frm.txtEx_rateUSD.Text = this.dataGV_Currencies.CurrentRow.Cells[4].Value.ToString();
            frm.txtCntry.Text = frm.cmboCountry.Text;
            frm.Text = "تحديث بيانات العملة :  " + this.dataGV_Currencies.CurrentRow.Cells[2].Value.ToString();
            frm.btnAddCurrency.Text = "تحديث";
            frm.state = "Update";
            frm.txtID.Visible = true;
            frm.lblid.Visible = true;
            frm.txtID.BackColor = Color.SteelBlue;

            frm.ShowDialog();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            //FRM_Preview frmV = new FRM_Preview();
            //id = dataGV_ACCs.CurrentRow.Cells[0].Value.ToString();
            //byte[] pic = (byte[])prd.get_imgProduct(id).Rows[0][0];
            //MemoryStream ms = new MemoryStream(pic);
            //frmV.pbox1.Image = Image.FromStream(ms);

            //frmV.ShowDialog();
        }
        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            //RPT.FRM_rpt_Crr_Product frmR = new RPT.FRM_rpt_Crr_Product();
            //frmR.sp_rpt_Curr_ProductTableAdapter.Fill(frmR.Curr_prod_DS.sp_rpt_Curr_Product, this.dataGV_ACCs.CurrentRow.Cells[0].Value.ToString());
            //frmR.reportViewer1.RefreshReport();
            //frmR.Text = "تقرير المنتج : " + this.dataGV_ACCs.CurrentRow.Cells[1].Value.ToString();
            //frmR.ShowDialog();           
        }
        private void btn_rpt_AllPrpdcts_Click(object sender, EventArgs e)
        {
            //RPT.FRM_rpt_AllProducts frmR = new RPT.FRM_rpt_AllProducts();
            //frmR.sp_rpt_All_ProductsTableAdapter.Fill(frmR.AllProduct_DS.sp_rpt_All_Products);
            //frmR.reportViewer1.RefreshReport();
            //frmR.Text = "تقرير بالمنتجات " ;
            //frmR.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ////RPT.rpt_all_products rpt = new RPT.rpt_all_products();
            ////ExportOptions export = new ExportOptions();
            ////DiskFileDestinationOptions diskOption = new DiskFileDestinationOptions();
            ////PdfFormatOptions PdfFormat = new PdfFormatOptions();

            ////diskOption.DiskFileName = @"E:\Products Report.pdf";
            ////export = rpt.ExportOptions;
            ////export.ExportDestinationType = ExportDestinationType.DiskFile;
            ////export.ExportDestinationOptions = diskOption;
            ////export.ExportFormatOptions = PdfFormat;
            ////export.ExportFormatType = ExportFormatType.PortableDocFormat;
            ////rpt.Refresh();
            ////rpt.Export();
            ////MessageBox.Show("Exporting Succeded", "Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            //frmAddCountry frm = new frmAddCountry();
            frm.cmboCountry_BIND();
            frm.state = "Add";
            frm.clearAll_Curr();
            frm.Text = "اضافة عملة";
            frm.btnAddCurrency.Text = "اضافة العملة";
            frm.txtID.Visible = false;
            frm.lblid.Visible = false;
            frm.ShowDialog();
        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("انت على وشك حذف العملة المحددة ، هل أنت متأكد من ذلك ؟", "حذف عملة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string crrncyName = this.dataGV_Currencies.CurrentRow.Cells[2].Value.ToString();  //for Entries

                string crrncyID = this.dataGV_Currencies.CurrentRow.Cells[0].Value.ToString();
                crrncyClass.Delete_Currency(crrncyID);
                //for Entries
                Program.entryCls.Add_Entry("حذف عملة", crrncyName, Program.Salesman, DateTime.Now);

                PrepareDataGV_Currencies();
            }
        }
    }
}
