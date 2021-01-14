namespace Remittances.Forms
{
    partial class frmAddCountry
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
            this.cmboCurrency = new System.Windows.Forms.ComboBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "اسم البلد";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "عملة البلد";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboCurrency
            // 
            this.cmboCurrency.BackColor = System.Drawing.Color.Azure;
            this.cmboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCurrency.Location = new System.Drawing.Point(125, 239);
            this.cmboCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboCurrency.Name = "cmboCurrency";
            this.cmboCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboCurrency.Size = new System.Drawing.Size(223, 29);
            this.cmboCurrency.TabIndex = 2;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(125, 157);
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountryName.Size = new System.Drawing.Size(223, 29);
            this.txtCountryName.TabIndex = 0;
            this.txtCountryName.Tag = "";
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCountry.Location = new System.Drawing.Point(96, 349);
            this.btnAddCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddCountry.Size = new System.Drawing.Size(122, 54);
            this.btnAddCountry.TabIndex = 6;
            this.btnAddCountry.Text = "اضافة البلد";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "أضف معلومات الـــبـلد  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(350, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(350, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCountryID
            // 
            this.txtCountryID.Location = new System.Drawing.Point(125, 98);
            this.txtCountryID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.ReadOnly = true;
            this.txtCountryID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountryID.Size = new System.Drawing.Size(223, 29);
            this.txtCountryID.TabIndex = 31;
            this.txtCountryID.Tag = "";
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryID.Location = new System.Drawing.Point(47, 100);
            this.lblCountryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountryID.Size = new System.Drawing.Size(64, 21);
            this.lblCountryID.TabIndex = 32;
            this.lblCountryID.Text = "رقم البلد";
            this.lblCountryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(250, 349);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(122, 54);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "اغلاق النافذة";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmAddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(404, 455);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCountryID);
            this.Controls.Add(this.txtCountryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboCurrency);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddCountry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة بلد جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmboCurrency;
        public System.Windows.Forms.TextBox txtCountryName;
        public System.Windows.Forms.Button btnAddCountry;
        public System.Windows.Forms.TextBox txtCountryID;
        public System.Windows.Forms.Label lblCountryID;
        public System.Windows.Forms.Button btnClose;
    }
}