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
    public partial class frmMatches : Form
    {
        //public string id;
        private readonly MatchClass mtchClass = new MatchClass();

        //FRM_AddMatch frmAddMtch = new FRM_AddMatch();
        private readonly AccountClass accCls = new AccountClass();
        public frmMatches()
        {
            InitializeComponent();
            PrepareDataGV_Matches();
            Prepare_cmbo_Search_Account();
        }
        //تلوين سطر بالداتاجريد حسب شرط معين
        private void DataGV_Matches_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int n = 0; n < dataGV_Matches.RowCount; n++)
            {
                if (dataGV_Matches.Rows[n].Cells[3].Value.ToString() == "0" & dataGV_Matches.Rows[n].Cells[4].Value.ToString() == "0")
                {
                    DataGridViewRow row = dataGV_Matches.Rows[n];
                    row.DefaultCellStyle.BackColor = Color.LawnGreen;
                    row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                    //row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    //row.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                
                else if (dataGV_Matches.Rows[n].Cells[4].Value.ToString() != "0")
                {
                    DataGridViewRow row = dataGV_Matches.Rows[n];
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    row.DefaultCellStyle.ForeColor = Color.Yellow;
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
        //رسم مستطيل حول السطر المحدد بطريقة جميلة
        //انظر الرابط
        //http://www.croitoriu.com/blog/2010/08/implementing-a-transparent-row-selection-in-a-datagridview-control/
        private void DataGV_Matches_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            // run this piece of code only for the selected row
            if (dgv.Rows[e.RowIndex].Selected)
            {
                int width = dataGV_Matches.Width;
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
        void CurrentRowTexts()
        {
            txtMatchID.Text = dataGV_Matches.CurrentRow.Cells[0].Value.ToString();
            txtAccID.Text = dataGV_Matches.CurrentRow.Cells[1].Value.ToString();
            txtCurrency.Text = dataGV_Matches.CurrentRow.Cells[2].Value.ToString();
            txtCreditor.Text = dataGV_Matches.CurrentRow.Cells[3].Value.ToString();
            txtDeptor.Text = dataGV_Matches.CurrentRow.Cells[4].Value.ToString();
            txtDateTime.Text = Convert.ToDateTime(dataGV_Matches.CurrentRow.Cells[5].Value).ToString("dd/MM/yyyy");
            txtMnote.Text = dataGV_Matches.CurrentRow.Cells[6].Value.ToString();
        }
        public void PrepareDataGV_Matches()
        {
            dataGV_Matches.DataSource = mtchClass.get_all_Matches();
            
            dataGV_Matches.Columns[0].HeaderText = "رقم المطابقة";
            dataGV_Matches.Columns[1].HeaderText = "رقم الحساب";
            dataGV_Matches.Columns[2].HeaderText = "العملة";
            dataGV_Matches.Columns[3].HeaderText = "دائن";
            dataGV_Matches.Columns[4].HeaderText = "مدين";
            dataGV_Matches.Columns[5].HeaderText = "تاريخ";
            dataGV_Matches.Columns[6].HeaderText = "ملاحظة";
           
            dataGV_Matches.RowHeadersWidth = 23;
            dataGV_Matches.Columns[0].Width = 55;
            dataGV_Matches.Columns[1].Width = 150;
            dataGV_Matches.Columns[2].Width = 90;
            dataGV_Matches.Columns[3].Width = 90;
            dataGV_Matches.Columns[4].Width = 90;
            dataGV_Matches.Columns[5].Width = 124;
            dataGV_Matches.Columns[6].Width = 220;
        }
        private void Prepare_cmbo_Search_Account()
        {
            cmbo_Search_Account.DataSource = accCls.get_all_Accounts();
            cmbo_Search_Account.DisplayMember = "acc_id";
            cmbo_Search_Account.ValueMember = "name";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGV_Matches.DataSource = mtchClass.SearchMatch(txtSearch.Text);
        }
        private void btnExitM_Click(object sender, EventArgs e)
        {            
            Close();
        }
        private void dataGV_Matches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRowTexts();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            using (FRM_AddMatch frmAddMtch = new FRM_AddMatch())
            {
                frmAddMtch.Text = "اضافة مطابقة جديدة";
                frmAddMtch.btnAddMatch.Text = "حفظ المطابقة";
                frmAddMtch.cleartexts();

                frmAddMtch.ShowDialog();
            }
            dataGV_Matches.DataSource = mtchClass.SearchMatch("");
        }
        private void btnChangeMatch_Click(object sender, EventArgs e)
        {
            // to save the selected row  
            int index = dataGV_Matches.CurrentRow.Index;

            using (FRM_AddMatch frmAddMtch = new FRM_AddMatch())
            {
                frmAddMtch.btnAddMatch.Text = "تعديل المطابقة";
                frmAddMtch.Text = "تعديل مطابقة ";
                frmAddMtch.lbl_dontChange.Visible = true;
                frmAddMtch.txtMatchID.Text = dataGV_Matches.CurrentRow.Cells[0].Value.ToString();
                frmAddMtch.cmbo_Account.Text = dataGV_Matches.CurrentRow.Cells[1].Value.ToString();
                frmAddMtch.cmbo_currency.Text = dataGV_Matches.CurrentRow.Cells[2].Value.ToString();
                frmAddMtch.txtCreditor.Text = dataGV_Matches.CurrentRow.Cells[3].Value.ToString();
                frmAddMtch.txtDeptor.Text = dataGV_Matches.CurrentRow.Cells[4].Value.ToString();
                frmAddMtch.dtm_mDate.Text = Convert.ToDateTime(dataGV_Matches.CurrentRow.Cells[5].Value).ToString("dd-MM-yyy");
                frmAddMtch.txtMnote.Text = dataGV_Matches.CurrentRow.Cells[6].Value.ToString();

                frmAddMtch.ShowDialog();
            }

            //to go back to the same row which was selected before 
            dataGV_Matches.DataSource = mtchClass.SearchMatch("");
            dataGV_Matches.Rows[index].Selected = true;
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("انت على وشك حذف المطابقة المحددة ، هل أنت متأكد من ذلك ؟", "حذف مطابقة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string accID = this.dataGV_Matches.CurrentRow.Cells[1].Value.ToString(); //for Entries

                int mtchID = Convert.ToInt32(this.dataGV_Matches.CurrentRow.Cells[0].Value.ToString());
                mtchClass.Delete_Match(mtchID);
                PrepareDataGV_Matches();

                //for Entries
                Program.entryCls.Add_Entry("حذف مطابقة", accID, Program.Salesman, DateTime.Now);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void DataGV_Matches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmbo_Search_Account_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string acc= cmbo_Search_Account.GetItemText(cmbo_Search_Account.SelectedItem);
            dataGV_Matches.DataSource = mtchClass.SearchMatch(acc);
        }

        private void FrmMatches_Load(object sender, EventArgs e)
        {

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

    }
}
