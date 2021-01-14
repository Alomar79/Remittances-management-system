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
    public partial class FRM_Accounts : Form
    {
        public string id;
        private AccountClass AccCls = new AccountClass();

        private static FRM_Accounts frmM;

        private static void frmM_Formclosed(object sender, FormClosedEventArgs e)
        {
            frmM = null;
        }
        public static FRM_Accounts getMainForm
        {
            get
            {
                if (frmM == null)
                {
                    frmM = new FRM_Accounts();
                    frmM.FormClosed += new FormClosedEventHandler(frmM_Formclosed);
                }
                return frmM;
            }
        }

        
        public FRM_Accounts()
        {
            InitializeComponent();
            if (frmM == null)
                frmM = this;

            PrepareDataGV_ACCs();
        }
        public void PrepareDataGV_ACCs()
        {
            dataGV_ACCs.DataSource = AccCls.get_all_Accounts();
            dataGV_ACCs.Columns[0].Visible = false;
            dataGV_ACCs.Columns[1].HeaderText = "الحساب";
            dataGV_ACCs.Columns[2].HeaderText = "الاسم";
            dataGV_ACCs.Columns[3].HeaderText = "نوع الحساب";
            dataGV_ACCs.Columns[4].HeaderText = "البلد";
            dataGV_ACCs.Columns[5].HeaderText = "الهاتف";
            dataGV_ACCs.Columns[6].HeaderText = "مـلاحـظـة";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGV_ACCs.DataSource = AccCls.SearchAccount(txtSearch.Text);
        }

        private void btnAddNewAcc_Click(object sender, EventArgs e)
        {
            frmAddAcc frm = new frmAddAcc();
            frm.ShowDialog();
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

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            frmAddAcc frm = new frmAddAcc();

            frm.txtAccID.Visible = true;
            frm.txtAccID.Enabled = false;
            frm.lblAccID.Visible = true;
            frm.txtAccID.Text = this.dataGV_ACCs.CurrentRow.Cells[1].Value.ToString();
            frm.txtAccName.Text = this.dataGV_ACCs.CurrentRow.Cells[2].Value.ToString();
            frm.cmboAccType.Text = this.dataGV_ACCs.CurrentRow.Cells[3].Value.ToString();
            frm.txtAccCountry.Text = this.dataGV_ACCs.CurrentRow.Cells[4].Value.ToString();
            frm.txtAccMob.Text = this.dataGV_ACCs.CurrentRow.Cells[5].Value.ToString();
            frm.txtAccNote.Text = this.dataGV_ACCs.CurrentRow.Cells[6].Value.ToString();

            frm.Text = "تحديث بيانات الحساب :  " + this.dataGV_ACCs.CurrentRow.Cells[1].Value.ToString();
            frm.btnAddAccount.Text = "تحديث";
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

        
    }
}
