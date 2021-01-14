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
    public partial class frmCountries : Form
    {
        public string id;
        private CountryClass cntryCls = new CountryClass();
        private currencyClass crrncyClass = new currencyClass();
        EntryClass entryCls = new EntryClass();
        private static frmCountries frmM;
        frmAddCountry frm = new frmAddCountry();
        private static void frmM_Formclosed(object sender, FormClosedEventArgs e)
        {
            frmM = null;
        }
        public static frmCountries getMainForm
        {
            get
            {
                if (frmM == null)
                {
                    frmM = new frmCountries();
                    frmM.FormClosed += new FormClosedEventHandler(frmM_Formclosed);
                }
                return frmM;
            }
        }
        public frmCountries()
        {
            InitializeComponent();
            if (frmM == null)
                frmM = this;

            PrepareDataGV_Countries();
        }
        public void PrepareDataGV_Countries()
        {
            dataGV_Countries.DataSource = cntryCls.get_all_countries();
            dataGV_Countries.Columns[0].Visible = false;
            dataGV_Countries.Columns[1].HeaderText = "البلد";
            dataGV_Countries.Columns[2].HeaderText = "العملة";
        }

        //تلوين سطر بالداتاجريد حسب شرط معين
        private void DataGV_Countries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int n = 0; n < dataGV_Countries.RowCount - 1; n++)
            {
                if (dataGV_Countries.Rows[n].Cells[1].Value.ToString() == "لبنان")
                {
                    DataGridViewRow row = dataGV_Countries.Rows[n];
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGV_Countries.DataSource = cntryCls.SearchCountry(txtSearch.Text);
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

            frm.txtCountryID.Visible = true;
            frm.txtCountryID.ReadOnly = true;
            frm.lblCountryID.Visible = true;
            frm.txtCountryID.Text = this.dataGV_Countries.CurrentRow.Cells[0].Value.ToString();
            frm.txtCountryName.Text = this.dataGV_Countries.CurrentRow.Cells[1].Value.ToString();

            frm.cmboCurrency_BIND();
            frm.cmboCurrency.Text = this.dataGV_Countries.CurrentRow.Cells[2].Value.ToString();

            frm.Text = "تحديث بيانات البلد :  " + this.dataGV_Countries.CurrentRow.Cells[1].Value.ToString();
            frm.btnAddCountry.Text = "تحديث";
            frm.state = "Update";

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
        private void BtnAddNewCountry_Click(object sender, EventArgs e)
        {
            frm.clearAll_Cntry();
            frm.Text = "اضافة بلد";
            frm.btnAddCountry.Text = "اضافة البلد";
            frm.state = "Add";
            frm.cmboCurrency_BIND();
            frm.ShowDialog();
        }
        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("انت على وشك حذف البلد المحدد ، هل أنت متأكد من ذلك ؟", "حذف بلد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string cntryName = this.dataGV_Countries.CurrentRow.Cells[1].Value.ToString(); //for Entries

                int cntryID = Convert.ToInt32(this.dataGV_Countries.CurrentRow.Cells[0].Value.ToString());
                cntryCls.Delete_Country(cntryID);
                PrepareDataGV_Countries();

                //for Entries
                Program.entryCls.Add_Entry("حذف بلد", cntryName, Program.Salesman, DateTime.Now);
            }
        }

       
    }
}
