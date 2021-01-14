namespace Remittances.Forms
{
    partial class frmCurrency
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
            this.txtSearchCurrency = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV_Currencies = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCurrency = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditCurrency = new System.Windows.Forms.Button();
            this.btnAddNewCurrency = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Currencies)).BeginInit();
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
            // txtSearchCurrency
            // 
            this.txtSearchCurrency.Location = new System.Drawing.Point(167, 26);
            this.txtSearchCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCurrency.Name = "txtSearchCurrency";
            this.txtSearchCurrency.Size = new System.Drawing.Size(234, 25);
            this.txtSearchCurrency.TabIndex = 0;
            this.txtSearchCurrency.TextChanged += new System.EventHandler(this.txtSearchCurrency_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_Currencies);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(434, 344);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة العملات";
            // 
            // dataGV_Currencies
            // 
            this.dataGV_Currencies.AllowUserToAddRows = false;
            this.dataGV_Currencies.AllowUserToDeleteRows = false;
            this.dataGV_Currencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Currencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Currencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_Currencies.Location = new System.Drawing.Point(4, 26);
            this.dataGV_Currencies.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_Currencies.MultiSelect = false;
            this.dataGV_Currencies.Name = "dataGV_Currencies";
            this.dataGV_Currencies.ReadOnly = true;
            this.dataGV_Currencies.RowTemplate.Height = 28;
            this.dataGV_Currencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Currencies.Size = new System.Drawing.Size(426, 314);
            this.dataGV_Currencies.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteCurrency);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnEditCurrency);
            this.groupBox2.Controls.Add(this.btnAddNewCurrency);
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
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCurrency.Location = new System.Drawing.Point(116, 30);
            this.btnDeleteCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(91, 61);
            this.btnDeleteCurrency.TabIndex = 9;
            this.btnDeleteCurrency.Text = "حذف العملة المحددة";
            this.btnDeleteCurrency.UseVisualStyleBackColor = false;
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
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
            // btnEditCurrency
            // 
            this.btnEditCurrency.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCurrency.Location = new System.Drawing.Point(224, 30);
            this.btnEditCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCurrency.Name = "btnEditCurrency";
            this.btnEditCurrency.Size = new System.Drawing.Size(91, 61);
            this.btnEditCurrency.TabIndex = 3;
            this.btnEditCurrency.Text = "تعديل العملة";
            this.btnEditCurrency.UseVisualStyleBackColor = false;
            this.btnEditCurrency.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // btnAddNewCurrency
            // 
            this.btnAddNewCurrency.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNewCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCurrency.Location = new System.Drawing.Point(332, 30);
            this.btnAddNewCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCurrency.Name = "btnAddNewCurrency";
            this.btnAddNewCurrency.Size = new System.Drawing.Size(91, 61);
            this.btnAddNewCurrency.TabIndex = 1;
            this.btnAddNewCurrency.Text = "اضافة عملة جديد";
            this.btnAddNewCurrency.UseVisualStyleBackColor = false;
            this.btnAddNewCurrency.Click += new System.EventHandler(this.btnAddNewCurrency_Click);
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(463, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchCurrency);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCurrency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نافذة إدارة العملات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Currencies)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCurrency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditCurrency;
        private System.Windows.Forms.Button btnAddNewCurrency;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DataGridView dataGV_Currencies;
        private System.Windows.Forms.Button btnDeleteCurrency;
    }
}