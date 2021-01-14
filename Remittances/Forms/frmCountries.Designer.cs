namespace Remittances.Forms
{
    partial class frmCountries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV_Countries = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDaleteCountry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnAddNewCountry = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Countries)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل كلمة للبحث عنها";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(167, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_Countries);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(434, 344);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة البلدان";
            // 
            // dataGV_Countries
            // 
            this.dataGV_Countries.AllowUserToAddRows = false;
            this.dataGV_Countries.AllowUserToDeleteRows = false;
            this.dataGV_Countries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Countries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_Countries.Location = new System.Drawing.Point(4, 26);
            this.dataGV_Countries.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_Countries.MultiSelect = false;
            this.dataGV_Countries.Name = "dataGV_Countries";
            this.dataGV_Countries.ReadOnly = true;
            this.dataGV_Countries.RowTemplate.Height = 28;
            this.dataGV_Countries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Countries.Size = new System.Drawing.Size(426, 314);
            this.dataGV_Countries.TabIndex = 0;
            this.dataGV_Countries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGV_Countries_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDaleteCountry);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnEditCountry);
            this.groupBox2.Controls.Add(this.btnAddNewCountry);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(20, 417);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(430, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة على السطر المحدد";
            // 
            // btnDaleteCountry
            // 
            this.btnDaleteCountry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDaleteCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaleteCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDaleteCountry.Location = new System.Drawing.Point(116, 30);
            this.btnDaleteCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnDaleteCountry.Name = "btnDaleteCountry";
            this.btnDaleteCountry.Size = new System.Drawing.Size(91, 61);
            this.btnDaleteCountry.TabIndex = 9;
            this.btnDaleteCountry.Text = "حذف البلد المحدد";
            this.btnDaleteCountry.UseVisualStyleBackColor = false;
            this.btnDaleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(8, 30);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 61);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "اغلاق النافذة";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCountry.Location = new System.Drawing.Point(224, 30);
            this.btnEditCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(91, 61);
            this.btnEditCountry.TabIndex = 3;
            this.btnEditCountry.Text = "تعديل بيانات البلد";
            this.btnEditCountry.UseVisualStyleBackColor = false;
            this.btnEditCountry.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // btnAddNewCountry
            // 
            this.btnAddNewCountry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNewCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCountry.Location = new System.Drawing.Point(332, 30);
            this.btnAddNewCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCountry.Name = "btnAddNewCountry";
            this.btnAddNewCountry.Size = new System.Drawing.Size(91, 61);
            this.btnAddNewCountry.TabIndex = 1;
            this.btnAddNewCountry.Text = "اضافة بلد جديد";
            this.btnAddNewCountry.UseVisualStyleBackColor = false;
            this.btnAddNewCountry.Click += new System.EventHandler(this.BtnAddNewCountry_Click);
            // 
            // frmCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCountries";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نافذة إدارة البلدان";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Countries)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditCountry;
        private System.Windows.Forms.Button btnAddNewCountry;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DataGridView dataGV_Countries;
        private System.Windows.Forms.Button btnDaleteCountry;
    }
}