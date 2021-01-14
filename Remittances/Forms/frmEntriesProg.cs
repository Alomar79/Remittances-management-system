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
    public partial class frmEntriesProg : Form
    {
        //public string id;
        private readonly EntryClass entryCls = new EntryClass();
        public frmEntriesProg()
        {
            InitializeComponent();

            PrepareDataGV_Entries();
        }
        void CurrentRowTexts()
        {
            txtEntryID.Text = this.dataGV_Entries.CurrentRow.Cells[0].Value.ToString();
            txtAction.Text = this.dataGV_Entries.CurrentRow.Cells[1].Value.ToString();
            txtRef.Text = dataGV_Entries.CurrentRow.Cells[2].Value.ToString();
            txtOfficer.Text = dataGV_Entries.CurrentRow.Cells[3].Value.ToString();
            txtDateTime.Text = Convert.ToDateTime(dataGV_Entries.CurrentRow.Cells[4].Value).ToString("dd/MM/yyyy");
            txtTime.Text = Convert.ToDateTime(dataGV_Entries.CurrentRow.Cells[4].Value).ToString("h:mm tt");
        }

        public void PrepareDataGV_Entries()
        {
            dataGV_Entries.DataSource = entryCls.get_all_Entries();
            
            dataGV_Entries.Columns[0].HeaderText = "رقم القيد";
            dataGV_Entries.Columns[1].HeaderText = "العملية";
            dataGV_Entries.Columns[2].HeaderText = "تم تنفيذه على";
            dataGV_Entries.Columns[3].HeaderText = "الموظف";
            dataGV_Entries.Columns[4].HeaderText = "تاريخ ووقت العملية";

            dataGV_Entries.RowHeadersWidth = 20;
            dataGV_Entries.Columns[0].Width = 66;
            dataGV_Entries.Columns[1].Width = 266;
            dataGV_Entries.Columns[2].Width = 127;
            dataGV_Entries.Columns[3].Width = 97;
            dataGV_Entries.Columns[4].Width = 175;
        }
        private void DataGV_Entries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int n = 0; n < dataGV_Entries.RowCount; n++)
            {
                if (dataGV_Entries.Rows[n].Cells[1].Value.ToString().Contains("حذف"))
                {
                    DataGridViewRow row = dataGV_Entries.Rows[n];
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                // for the first cell paint paint the background as highlight and text as white in case of selection
                if (e.ColumnIndex == 0)
                {
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }

            }
        }
            private void DataGV_Entries_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            // run this piece of code only for the selected row
            if (dgv.Rows[e.RowIndex].Selected)
            {
                int width = dataGV_Entries.Width;
                Rectangle r = dgv.GetRowDisplayRectangle(e.RowIndex, false);
                var rect = new Rectangle(r.X, r.Y, width - 1, r.Height - 1);
                // draw the border around the selected row using the highlight color and using a border width of 2
                ControlPaint.DrawBorder(e.Graphics, rect,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid);
            }
        }
            private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGV_Entries.DataSource = entryCls.SearchEntry(txtSearch.Text);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //private void btnPrint_All_Entries_Click(object sender, EventArgs e)
        //{
        //}
        //private void btnDelAcc_Click(object sender, EventArgs e)
        //{
            //if (MessageBox.Show("did you sure to delete ?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    id = dataGV_ACCs.CurrentRow.Cells[0].Value.ToString();
            //    AccCls.Delete_Product(id);
            //    MessageBox.Show("تمت عملية الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else MessageBox.Show("تم إلغاء عملية الحذف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dataGV_ACCs.DataSource = prd.get_all_products();

        //}
        //private void btnPrint_Curr_Entry_Click(object sender, EventArgs e)
        //{
            //frmAddAcc frm = new frmAddAcc();

            //frm.txtAccID.Visible = true;
            //frm.txtAccID.Enabled = false;
            //frm.lblAccID.Visible = true;
            //frm.txtAccID.Text = this.dataGV_Entries.CurrentRow.Cells[1].Value.ToString();
            //frm.txtAccName.Text = this.dataGV_Entries.CurrentRow.Cells[2].Value.ToString();
            //frm.cmboAccType.Text = this.dataGV_Entries.CurrentRow.Cells[3].Value.ToString();
            //frm.txtAccCountry.Text = this.dataGV_Entries.CurrentRow.Cells[4].Value.ToString();
            //frm.txtAccMob.Text = this.dataGV_Entries.CurrentRow.Cells[5].Value.ToString();
            //frm.txtAccNote.Text = this.dataGV_Entries.CurrentRow.Cells[6].Value.ToString();

            //frm.Text = "تحديث بيانات الحساب :  " + this.dataGV_Entries.CurrentRow.Cells[1].Value.ToString();
            //frm.btnAddAccount.Text = "تحديث";
            //frm.state = "Update";

            //frm.ShowDialog();
        //}
        
        //private void btnPreview_Click(object sender, EventArgs e)
        //{
            //FRM_Preview frmV = new FRM_Preview();
            //id = dataGV_ACCs.CurrentRow.Cells[0].Value.ToString();
            //byte[] pic = (byte[])prd.get_imgProduct(id).Rows[0][0];
            //MemoryStream ms = new MemoryStream(pic);
            //frmV.pbox1.Image = Image.FromStream(ms);
            //frmV.ShowDialog();
        //}
        //private void btnPrintSelected_Click(object sender, EventArgs e)
        //{
        //    RPT.FRM_rpt_Crr_Product frmR = new RPT.FRM_rpt_Crr_Product();
        //    frmR.sp_rpt_Curr_ProductTableAdapter.Fill(frmR.Curr_prod_DS.sp_rpt_Curr_Product, this.dataGV_ACCs.CurrentRow.Cells[0].Value.ToString());
        //    frmR.reportViewer1.RefreshReport();
        //    frmR.Text = "تقرير المنتج : " + this.dataGV_ACCs.CurrentRow.Cells[1].Value.ToString();
        //    frmR.ShowDialog();
        //}
        //private void btn_rpt_AllPrpdcts_Click(object sender, EventArgs e)
        //{
            //RPT.FRM_rpt_AllProducts frmR = new RPT.FRM_rpt_AllProducts();
            //frmR.sp_rpt_All_ProductsTableAdapter.Fill(frmR.AllProduct_DS.sp_rpt_All_Products);
            //frmR.reportViewer1.RefreshReport();
            //frmR.Text = "تقرير بالمنتجات " ;
            //frmR.ShowDialog();
        //}
        //private void button7_Click(object sender, EventArgs e)
        //{
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
        //}
        private void DataGV_Entries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRowTexts();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }
        private void BtnPrint_All_Entries_Click(object sender, EventArgs e)
        {
        }
        private void BtnDeleteLogins_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("انت على وشك حذف جميع القيود التي تخص تسجيلات الدخول للمستخدمين، هل أنت متأكد؟", "مسح تسجيلات الدخول", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                string entryAction = "تسجيل دخول الى البرنامج";       
                Program.entryCls.Delete_Logins_Entry(entryAction);
                PrepareDataGV_Entries();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("انت على وشك حذف جميع القيود في البرنامج ، هل أنت متأكد؟", "مسح تسجيلات الدخول", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {                
                Program.entryCls.Delete_all_Logins_Entries();
                PrepareDataGV_Entries();
            }
        }

        private void BtnPrint_Curr_Entry_Click(object sender, EventArgs e)
        {

        }
        private void DataGV_Entries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
