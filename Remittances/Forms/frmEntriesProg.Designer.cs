namespace Remittances.Forms
{
    partial class frmEntriesProg
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
            this.dataGV_Entries = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteLogins = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint_Curr_Entry = new System.Windows.Forms.Button();
            this.btnPrint_All_Entries = new System.Windows.Forms.Button();
            this.txtEntryID = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtOfficer = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Entries)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل كلمة للبحث عنها";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(339, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(385, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_Entries);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(765, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة القيود";
            // 
            // dataGV_Entries
            // 
            this.dataGV_Entries.AllowUserToAddRows = false;
            this.dataGV_Entries.AllowUserToDeleteRows = false;
            this.dataGV_Entries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV_Entries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGV_Entries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Entries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_Entries.Location = new System.Drawing.Point(4, 23);
            this.dataGV_Entries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGV_Entries.MultiSelect = false;
            this.dataGV_Entries.Name = "dataGV_Entries";
            this.dataGV_Entries.ReadOnly = true;
            this.dataGV_Entries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGV_Entries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGV_Entries.RowTemplate.Height = 28;
            this.dataGV_Entries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Entries.Size = new System.Drawing.Size(757, 284);
            this.dataGV_Entries.TabIndex = 0;
            this.dataGV_Entries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_Entries_CellClick);
            this.dataGV_Entries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_Entries_CellContentClick);
            this.dataGV_Entries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGV_Entries_CellFormatting);
            this.dataGV_Entries.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGV_Entries_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnDeleteLogins);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnPrint_Curr_Entry);
            this.groupBox2.Controls.Add(this.btnPrint_All_Entries);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 469);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(765, 143);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة على السطر المحدد";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(66, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
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
            this.button1.Text = "مسح كافة قيود البرنامج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDeleteLogins
            // 
            this.btnDeleteLogins.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteLogins.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteLogins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLogins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLogins.Location = new System.Drawing.Point(538, 85);
            this.btnDeleteLogins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteLogins.Name = "btnDeleteLogins";
            this.btnDeleteLogins.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteLogins.TabIndex = 9;
            this.btnDeleteLogins.Text = "مسح تسجيلات الدخول والخروج";
            this.btnDeleteLogins.UseVisualStyleBackColor = false;
            this.btnDeleteLogins.Click += new System.EventHandler(this.BtnDeleteLogins_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(66, 25);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "اغلاق النافذة";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint_Curr_Entry
            // 
            this.btnPrint_Curr_Entry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrint_Curr_Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint_Curr_Entry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint_Curr_Entry.Location = new System.Drawing.Point(302, 25);
            this.btnPrint_Curr_Entry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint_Curr_Entry.Name = "btnPrint_Curr_Entry";
            this.btnPrint_Curr_Entry.Size = new System.Drawing.Size(150, 35);
            this.btnPrint_Curr_Entry.TabIndex = 3;
            this.btnPrint_Curr_Entry.Text = "طباعة القيد المحدد";
            this.btnPrint_Curr_Entry.UseVisualStyleBackColor = false;
            this.btnPrint_Curr_Entry.Click += new System.EventHandler(this.BtnPrint_Curr_Entry_Click);
            // 
            // btnPrint_All_Entries
            // 
            this.btnPrint_All_Entries.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrint_All_Entries.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint_All_Entries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint_All_Entries.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint_All_Entries.Location = new System.Drawing.Point(538, 25);
            this.btnPrint_All_Entries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint_All_Entries.Name = "btnPrint_All_Entries";
            this.btnPrint_All_Entries.Size = new System.Drawing.Size(150, 35);
            this.btnPrint_All_Entries.TabIndex = 1;
            this.btnPrint_All_Entries.Text = "طباعة تقرير";
            this.btnPrint_All_Entries.UseVisualStyleBackColor = false;
            this.btnPrint_All_Entries.Click += new System.EventHandler(this.BtnPrint_All_Entries_Click);
            // 
            // txtEntryID
            // 
            this.txtEntryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryID.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryID.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtEntryID.Location = new System.Drawing.Point(676, 37);
            this.txtEntryID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEntryID.Name = "txtEntryID";
            this.txtEntryID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryID.Size = new System.Drawing.Size(88, 27);
            this.txtEntryID.TabIndex = 5;
            // 
            // txtAction
            // 
            this.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAction.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAction.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtAction.Location = new System.Drawing.Point(405, 37);
            this.txtAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAction.Name = "txtAction";
            this.txtAction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAction.Size = new System.Drawing.Size(272, 27);
            this.txtAction.TabIndex = 6;
            // 
            // txtRef
            // 
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRef.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtRef.Location = new System.Drawing.Point(287, 37);
            this.txtRef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRef.Name = "txtRef";
            this.txtRef.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRef.Size = new System.Drawing.Size(121, 27);
            this.txtRef.TabIndex = 7;
            // 
            // txtOfficer
            // 
            this.txtOfficer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOfficer.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficer.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtOfficer.Location = new System.Drawing.Point(186, 37);
            this.txtOfficer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOfficer.Name = "txtOfficer";
            this.txtOfficer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOfficer.Size = new System.Drawing.Size(102, 27);
            this.txtOfficer.TabIndex = 8;
            // 
            // txtDateTime
            // 
            this.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateTime.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtDateTime.Location = new System.Drawing.Point(83, 37);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTime.Size = new System.Drawing.Size(104, 27);
            this.txtDateTime.TabIndex = 9;
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtTime.Location = new System.Drawing.Point(1, 37);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTime.Name = "txtTime";
            this.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTime.Size = new System.Drawing.Size(83, 27);
            this.txtTime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "رقم القيد";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(272, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "العملية";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "تم تنفيذه على";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "الموظف";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "التاريخ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "الوقت";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEntryID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAction);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtRef);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtOfficer);
            this.groupBox3.Controls.Add(this.txtDateTime);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTime);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 374);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(765, 66);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // frmEntriesProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(790, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmEntriesProg";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قيود البرنامج";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Entries)).EndInit();
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
        private System.Windows.Forms.Button btnPrint_Curr_Entry;
        private System.Windows.Forms.Button btnPrint_All_Entries;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEntryID;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtOfficer;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteLogins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGV_Entries;
    }
}