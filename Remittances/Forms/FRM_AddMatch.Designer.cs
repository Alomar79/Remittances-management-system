namespace Remittances.Forms
{
    partial class FRM_AddMatch
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeptor = new System.Windows.Forms.TextBox();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMnote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtm_mDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_dontChange = new System.Windows.Forms.Label();
            this.cmbo_Account = new System.Windows.Forms.ComboBox();
            this.cmbo_currency = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "تاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "رقم الحساب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "دائن (له علينا)";
            // 
            // txtCreditor
            // 
            this.txtCreditor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditor.Location = new System.Drawing.Point(134, 216);
            this.txtCreditor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditor.Name = "txtCreditor";
            this.txtCreditor.Size = new System.Drawing.Size(230, 29);
            this.txtCreditor.TabIndex = 2;
            this.txtCreditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCreditor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "مدين لنا";
            // 
            // txtDeptor
            // 
            this.txtDeptor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptor.Location = new System.Drawing.Point(134, 276);
            this.txtDeptor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeptor.Name = "txtDeptor";
            this.txtDeptor.Size = new System.Drawing.Size(230, 29);
            this.txtDeptor.TabIndex = 3;
            this.txtDeptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDeptor_KeyPress);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMatch.Location = new System.Drawing.Point(99, 476);
            this.btnAddMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(129, 46);
            this.btnAddMatch.TabIndex = 5;
            this.btnAddMatch.Text = "حفظ المطابقة";
            this.btnAddMatch.UseVisualStyleBackColor = false;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(268, 476);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "خروج من النموذج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "العملة";
            // 
            // txtMnote
            // 
            this.txtMnote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnote.Location = new System.Drawing.Point(134, 405);
            this.txtMnote.Margin = new System.Windows.Forms.Padding(4);
            this.txtMnote.Name = "txtMnote";
            this.txtMnote.Size = new System.Drawing.Size(230, 29);
            this.txtMnote.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "ملاحظة";
            // 
            // txtMatchID
            // 
            this.txtMatchID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMatchID.Enabled = false;
            this.txtMatchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchID.Location = new System.Drawing.Point(134, 44);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.Size = new System.Drawing.Size(197, 29);
            this.txtMatchID.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(35, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "رقم المطابقة";
            // 
            // dtm_mDate
            // 
            this.dtm_mDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_mDate.Location = new System.Drawing.Point(135, 349);
            this.dtm_mDate.Name = "dtm_mDate";
            this.dtm_mDate.Size = new System.Drawing.Size(229, 29);
            this.dtm_mDate.TabIndex = 22;
            // 
            // lbl_dontChange
            // 
            this.lbl_dontChange.AutoSize = true;
            this.lbl_dontChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dontChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_dontChange.Location = new System.Drawing.Point(136, 327);
            this.lbl_dontChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dontChange.Name = "lbl_dontChange";
            this.lbl_dontChange.Size = new System.Drawing.Size(210, 21);
            this.lbl_dontChange.TabIndex = 23;
            this.lbl_dontChange.Text = "يفضل عدم تغيير تاريخ المطابقة";
            this.lbl_dontChange.Visible = false;
            // 
            // cmbo_Account
            // 
            this.cmbo_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_Account.FormattingEnabled = true;
            this.cmbo_Account.Location = new System.Drawing.Point(134, 101);
            this.cmbo_Account.Name = "cmbo_Account";
            this.cmbo_Account.Size = new System.Drawing.Size(230, 29);
            this.cmbo_Account.TabIndex = 24;
            // 
            // cmbo_currency
            // 
            this.cmbo_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_currency.FormattingEnabled = true;
            this.cmbo_currency.Location = new System.Drawing.Point(134, 160);
            this.cmbo_currency.Name = "cmbo_currency";
            this.cmbo_currency.Size = new System.Drawing.Size(230, 29);
            this.cmbo_currency.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "بالعملة المذكورة أعلاه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "بالعملة المذكورة أعلاه";
            // 
            // FRM_AddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(432, 556);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbo_currency);
            this.Controls.Add(this.cmbo_Account);
            this.Controls.Add(this.lbl_dontChange);
            this.Controls.Add(this.dtm_mDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMatchID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMnote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeptor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCreditor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddMatch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة مطابقة جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCreditor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDeptor;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMnote;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtm_mDate;
        public System.Windows.Forms.Label lbl_dontChange;
        public System.Windows.Forms.ComboBox cmbo_Account;
        public System.Windows.Forms.ComboBox cmbo_currency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}