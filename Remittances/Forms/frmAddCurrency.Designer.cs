namespace Remittances.Forms
{
    partial class frmAddCurrency
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboCountry = new System.Windows.Forms.ComboBox();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.lblCurrencyID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEx_rateUSD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCntry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "العملة";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(124, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "اختر البلد";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboCountry
            // 
            this.cmboCountry.BackColor = System.Drawing.Color.Azure;
            this.cmboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCountry.FormattingEnabled = true;
            this.cmboCountry.Location = new System.Drawing.Point(200, 260);
            this.cmboCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboCountry.Name = "cmboCountry";
            this.cmboCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboCountry.Size = new System.Drawing.Size(223, 29);
            this.cmboCountry.TabIndex = 0;
            this.cmboCountry.SelectionChangeCommitted += new System.EventHandler(this.CmboCountry_SelectionChangeCommitted);
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(200, 173);
            this.txtCurrencyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrencyName.Size = new System.Drawing.Size(223, 29);
            this.txtCurrencyName.TabIndex = 1;
            this.txtCurrencyName.Tag = "";
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCurrency.Location = new System.Drawing.Point(175, 440);
            this.btnAddCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddCurrency.Size = new System.Drawing.Size(122, 54);
            this.btnAddCurrency.TabIndex = 4;
            this.btnAddCurrency.Text = "اضافة العملة";
            this.btnAddCurrency.UseVisualStyleBackColor = false;
            this.btnAddCurrency.Click += new System.EventHandler(this.BtnAddCurrency_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "أضف معلومات الــعملة  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(423, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Location = new System.Drawing.Point(200, 126);
            this.txtCurrencyCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrencyCode.Size = new System.Drawing.Size(223, 29);
            this.txtCurrencyCode.TabIndex = 0;
            this.txtCurrencyCode.Tag = "";
            // 
            // lblCurrencyID
            // 
            this.lblCurrencyID.AutoSize = true;
            this.lblCurrencyID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyID.Location = new System.Drawing.Point(114, 128);
            this.lblCurrencyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrencyID.Name = "lblCurrencyID";
            this.lblCurrencyID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrencyID.Size = new System.Drawing.Size(76, 21);
            this.lblCurrencyID.TabIndex = 32;
            this.lblCurrencyID.Text = "رمز العملة";
            this.lblCurrencyID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(329, 440);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(122, 54);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "اغلاق النافذة";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(423, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(117, 48);
            this.label5.TabIndex = 35;
            this.label5.Text = "سعر الدولار أمام هذه العملة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEx_rateUSD
            // 
            this.txtEx_rateUSD.Location = new System.Drawing.Point(200, 356);
            this.txtEx_rateUSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEx_rateUSD.Name = "txtEx_rateUSD";
            this.txtEx_rateUSD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEx_rateUSD.Size = new System.Drawing.Size(223, 29);
            this.txtEx_rateUSD.TabIndex = 3;
            this.txtEx_rateUSD.Tag = "";
            this.txtEx_rateUSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEx_rateUSD_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(91, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "1 $ = ( ?) ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCntry
            // 
            this.txtCntry.Location = new System.Drawing.Point(200, 297);
            this.txtCntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCntry.Name = "txtCntry";
            this.txtCntry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCntry.Size = new System.Drawing.Size(223, 29);
            this.txtCntry.TabIndex = 1;
            this.txtCntry.Tag = "";
            this.txtCntry.TextChanged += new System.EventHandler(this.TxtCntry_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(134, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "أو أكتبه";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(200, 81);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(223, 29);
            this.txtID.TabIndex = 41;
            this.txtID.Tag = "";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(55, 84);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblid.Size = new System.Drawing.Size(135, 21);
            this.lblid.TabIndex = 42;
            this.lblid.Text = "رقم تسلسلي تلقائي";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(422, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(53, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "اختر البلد من القائمة ، أو اكتبه اذا لم يكن موجوداً :";
            // 
            // frmAddCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(548, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmboCountry);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtCntry);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEx_rateUSD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurrencyID);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCurrency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCurrencyName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddCurrency";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة عملة جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmboCountry;
        public System.Windows.Forms.TextBox txtCurrencyName;
        public System.Windows.Forms.Button btnAddCurrency;
        public System.Windows.Forms.TextBox txtCurrencyCode;
        public System.Windows.Forms.Label lblCurrencyID;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEx_rateUSD;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCntry;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}