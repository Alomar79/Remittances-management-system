namespace Remittances.Forms
{
    partial class frmAddAcc
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccNote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboAccType = new System.Windows.Forms.ComboBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtAccMob = new System.Windows.Forms.TextBox();
            this.txtAccCountry = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.lblAccID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "ملاحظة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "رقم الهاتف";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "الـبـلد (مكان العمل)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "الاسم";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccNote
            // 
            this.txtAccNote.Location = new System.Drawing.Point(149, 357);
            this.txtAccNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNote.Multiline = true;
            this.txtAccNote.Name = "txtAccNote";
            this.txtAccNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAccNote.Size = new System.Drawing.Size(290, 56);
            this.txtAccNote.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "اختر نوع الحساب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboAccType
            // 
            this.cmboAccType.BackColor = System.Drawing.Color.Azure;
            this.cmboAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboAccType.FormattingEnabled = true;
            this.cmboAccType.Items.AddRange(new object[] {
            "حسابات شركتنا",
            "حساب شركة نتعامل معها",
            "حساب مندوب",
            "حساب زبون عادي"});
            this.cmboAccType.Location = new System.Drawing.Point(149, 195);
            this.cmboAccType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboAccType.Name = "cmboAccType";
            this.cmboAccType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboAccType.Size = new System.Drawing.Size(290, 29);
            this.cmboAccType.TabIndex = 2;
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(149, 138);
            this.txtAccName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccName.Size = new System.Drawing.Size(290, 29);
            this.txtAccName.TabIndex = 0;
            this.txtAccName.Tag = "";
            // 
            // txtAccMob
            // 
            this.txtAccMob.Location = new System.Drawing.Point(149, 302);
            this.txtAccMob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccMob.Name = "txtAccMob";
            this.txtAccMob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccMob.Size = new System.Drawing.Size(290, 29);
            this.txtAccMob.TabIndex = 4;
            // 
            // txtAccCountry
            // 
            this.txtAccCountry.Location = new System.Drawing.Point(149, 248);
            this.txtAccCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccCountry.Name = "txtAccCountry";
            this.txtAccCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccCountry.Size = new System.Drawing.Size(290, 29);
            this.txtAccCountry.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAccount.Location = new System.Drawing.Point(106, 469);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddAccount.Size = new System.Drawing.Size(156, 54);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "اضافة الحساب";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "أضف معلومات الحساب  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(441, 143);
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
            this.label3.Location = new System.Drawing.Point(441, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(441, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(149, 89);
            this.txtAccID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.ReadOnly = true;
            this.txtAccID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccID.Size = new System.Drawing.Size(290, 29);
            this.txtAccID.TabIndex = 31;
            this.txtAccID.Tag = "";
            this.txtAccID.Visible = false;
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccID.Location = new System.Drawing.Point(52, 91);
            this.lblAccID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAccID.Size = new System.Drawing.Size(87, 21);
            this.lblAccID.TabIndex = 32;
            this.lblAccID.Text = "رقم الحساب";
            this.lblAccID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAccID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(300, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(156, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "اغلاق النافذة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmAddAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(493, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboAccType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAccCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAccMob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccNote);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddAcc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة حساب جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtAccNote;
        public System.Windows.Forms.ComboBox cmboAccType;
        public System.Windows.Forms.TextBox txtAccName;
        public System.Windows.Forms.TextBox txtAccMob;
        public System.Windows.Forms.TextBox txtAccCountry;
        public System.Windows.Forms.Button btnAddAccount;
        public System.Windows.Forms.TextBox txtAccID;
        public System.Windows.Forms.Label lblAccID;
        public System.Windows.Forms.Button button1;
    }
}