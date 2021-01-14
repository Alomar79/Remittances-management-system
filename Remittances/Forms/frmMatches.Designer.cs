namespace Remittances.Forms
{
    partial class frmMatches
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
            this.dataGV_Matches = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeMatch = new System.Windows.Forms.Button();
            this.btnExitM = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtCreditor = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeptor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMnote = new System.Windows.Forms.TextBox();
            this.cmbo_Search_Account = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Matches)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "أو ..   ادخل كلمة للبحث عنها";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(630, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_Matches);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(823, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة المطابقات - برتقالي(مدين لنا)";
            // 
            // dataGV_Matches
            // 
            this.dataGV_Matches.AllowUserToAddRows = false;
            this.dataGV_Matches.AllowUserToDeleteRows = false;
            this.dataGV_Matches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV_Matches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGV_Matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Matches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_Matches.Location = new System.Drawing.Point(4, 23);
            this.dataGV_Matches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGV_Matches.MultiSelect = false;
            this.dataGV_Matches.Name = "dataGV_Matches";
            this.dataGV_Matches.ReadOnly = true;
            this.dataGV_Matches.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGV_Matches.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGV_Matches.RowTemplate.Height = 28;
            this.dataGV_Matches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Matches.Size = new System.Drawing.Size(815, 284);
            this.dataGV_Matches.TabIndex = 0;
            this.dataGV_Matches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Matches_CellClick);
            this.dataGV_Matches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_Matches_CellContentClick);
            this.dataGV_Matches.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGV_Matches_CellFormatting);
            this.dataGV_Matches.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGV_Matches_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnChangeMatch);
            this.groupBox2.Controls.Add(this.btnExitM);
            this.groupBox2.Controls.Add(this.btnDeleteMatch);
            this.groupBox2.Controls.Add(this.btnAddMatch);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 469);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(819, 143);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة على السطر المحدد";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(302, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "تقرير";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnChangeMatch
            // 
            this.btnChangeMatch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChangeMatch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChangeMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMatch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMatch.Location = new System.Drawing.Point(538, 85);
            this.btnChangeMatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeMatch.Name = "btnChangeMatch";
            this.btnChangeMatch.Size = new System.Drawing.Size(150, 35);
            this.btnChangeMatch.TabIndex = 9;
            this.btnChangeMatch.Text = "تعديل مطابقة";
            this.btnChangeMatch.UseVisualStyleBackColor = false;
            this.btnChangeMatch.Click += new System.EventHandler(this.btnChangeMatch_Click);
            // 
            // btnExitM
            // 
            this.btnExitM.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExitM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitM.ForeColor = System.Drawing.Color.Crimson;
            this.btnExitM.Location = new System.Drawing.Point(66, 33);
            this.btnExitM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExitM.Name = "btnExitM";
            this.btnExitM.Size = new System.Drawing.Size(150, 35);
            this.btnExitM.TabIndex = 8;
            this.btnExitM.Text = "اغلاق النافذة";
            this.btnExitM.UseVisualStyleBackColor = false;
            this.btnExitM.Click += new System.EventHandler(this.btnExitM_Click);
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMatch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMatch.Location = new System.Drawing.Point(302, 33);
            this.btnDeleteMatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteMatch.TabIndex = 3;
            this.btnDeleteMatch.Text = "حذف مطابقة";
            this.btnDeleteMatch.UseVisualStyleBackColor = false;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddMatch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMatch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMatch.Location = new System.Drawing.Point(538, 33);
            this.btnAddMatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(150, 35);
            this.btnAddMatch.TabIndex = 1;
            this.btnAddMatch.Text = "اضافة مطابقة";
            this.btnAddMatch.UseVisualStyleBackColor = false;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // txtMatchID
            // 
            this.txtMatchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchID.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchID.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtMatchID.Location = new System.Drawing.Point(740, 37);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMatchID.Size = new System.Drawing.Size(79, 27);
            this.txtMatchID.TabIndex = 5;
            // 
            // txtAccID
            // 
            this.txtAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccID.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccID.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtAccID.Location = new System.Drawing.Point(580, 37);
            this.txtAccID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccID.Size = new System.Drawing.Size(161, 27);
            this.txtAccID.TabIndex = 6;
            // 
            // txtCurrency
            // 
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCurrency.Location = new System.Drawing.Point(497, 37);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrency.Size = new System.Drawing.Size(84, 27);
            this.txtCurrency.TabIndex = 7;
            // 
            // txtCreditor
            // 
            this.txtCreditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditor.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditor.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtCreditor.Location = new System.Drawing.Point(396, 37);
            this.txtCreditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCreditor.Name = "txtCreditor";
            this.txtCreditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCreditor.Size = new System.Drawing.Size(102, 27);
            this.txtCreditor.TabIndex = 8;
            // 
            // txtDateTime
            // 
            this.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateTime.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtDateTime.Location = new System.Drawing.Point(207, 37);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTime.Size = new System.Drawing.Size(89, 27);
            this.txtDateTime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "رقم المطابقة";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(161, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "رقم الحساب";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "العملة";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "دائن(له علينا)";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "التاريخ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDeptor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtMnote);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMatchID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAccID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCurrency);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCreditor);
            this.groupBox3.Controls.Add(this.txtDateTime);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 374);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(819, 66);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(102, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "مدين";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDeptor
            // 
            this.txtDeptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptor.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptor.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtDeptor.Location = new System.Drawing.Point(295, 37);
            this.txtDeptor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeptor.Name = "txtDeptor";
            this.txtDeptor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeptor.Size = new System.Drawing.Size(102, 27);
            this.txtDeptor.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(208, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "ملاحظة";
            // 
            // txtMnote
            // 
            this.txtMnote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMnote.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnote.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtMnote.Location = new System.Drawing.Point(0, 37);
            this.txtMnote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMnote.Name = "txtMnote";
            this.txtMnote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMnote.Size = new System.Drawing.Size(208, 27);
            this.txtMnote.TabIndex = 17;
            // 
            // cmbo_Search_Account
            // 
            this.cmbo_Search_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_Search_Account.FormattingEnabled = true;
            this.cmbo_Search_Account.Location = new System.Drawing.Point(214, 22);
            this.cmbo_Search_Account.Name = "cmbo_Search_Account";
            this.cmbo_Search_Account.Size = new System.Drawing.Size(230, 27);
            this.cmbo_Search_Account.TabIndex = 26;
            this.cmbo_Search_Account.SelectionChangeCommitted += new System.EventHandler(this.Cmbo_Search_Account_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "اختر رقم الحساب";
            // 
            // frmMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(850, 665);
            this.Controls.Add(this.cmbo_Search_Account);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmMatches";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المطابقات";
            this.Load += new System.EventHandler(this.FrmMatches_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Matches)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Button btnExitM;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtCreditor;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGV_Matches;
        private System.Windows.Forms.Button btnChangeMatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMnote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeptor;
        public System.Windows.Forms.ComboBox cmbo_Search_Account;
        private System.Windows.Forms.Label label7;
    }
}