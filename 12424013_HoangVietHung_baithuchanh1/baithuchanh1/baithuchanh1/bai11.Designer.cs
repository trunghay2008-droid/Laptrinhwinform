namespace baithuchanh1
{
    partial class bai11
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.rdoHocKyI = new System.Windows.Forms.RadioButton();
            this.rdoHocKyII = new System.Windows.Forms.RadioButton();
            this.rdoHocKyIII = new System.Windows.Forms.RadioButton();
            this.rdoHocKyIV = new System.Windows.Forms.RadioButton();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niên Khóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Môn học:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(142, 32);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(247, 22);
            this.txtMSSV.TabIndex = 7;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(142, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(370, 22);
            this.txtHoTen.TabIndex = 8;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Items.AddRange(new object[] {
            "2025-2026"});
            this.cboNienKhoa.Location = new System.Drawing.Point(142, 109);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(247, 24);
            this.cboNienKhoa.TabIndex = 9;
            this.cboNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboNienKhoa_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "124241"});
            this.cboLop.Location = new System.Drawing.Point(142, 151);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(247, 24);
            this.cboLop.TabIndex = 10;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // rdoHocKyI
            // 
            this.rdoHocKyI.AutoSize = true;
            this.rdoHocKyI.Location = new System.Drawing.Point(139, 190);
            this.rdoHocKyI.Name = "rdoHocKyI";
            this.rdoHocKyI.Size = new System.Drawing.Size(31, 20);
            this.rdoHocKyI.TabIndex = 11;
            this.rdoHocKyI.TabStop = true;
            this.rdoHocKyI.Text = "I";
            this.rdoHocKyI.UseVisualStyleBackColor = true;
            this.rdoHocKyI.CheckedChanged += new System.EventHandler(this.rdoHocKyI_CheckedChanged);
            // 
            // rdoHocKyII
            // 
            this.rdoHocKyII.AutoSize = true;
            this.rdoHocKyII.Location = new System.Drawing.Point(223, 190);
            this.rdoHocKyII.Name = "rdoHocKyII";
            this.rdoHocKyII.Size = new System.Drawing.Size(34, 20);
            this.rdoHocKyII.TabIndex = 12;
            this.rdoHocKyII.TabStop = true;
            this.rdoHocKyII.Text = "II";
            this.rdoHocKyII.UseVisualStyleBackColor = true;
            this.rdoHocKyII.CheckedChanged += new System.EventHandler(this.rdoHocKyII_CheckedChanged);
            // 
            // rdoHocKyIII
            // 
            this.rdoHocKyIII.AutoSize = true;
            this.rdoHocKyIII.Location = new System.Drawing.Point(296, 190);
            this.rdoHocKyIII.Name = "rdoHocKyIII";
            this.rdoHocKyIII.Size = new System.Drawing.Size(37, 20);
            this.rdoHocKyIII.TabIndex = 13;
            this.rdoHocKyIII.TabStop = true;
            this.rdoHocKyIII.Text = "III";
            this.rdoHocKyIII.UseVisualStyleBackColor = true;
            this.rdoHocKyIII.CheckedChanged += new System.EventHandler(this.rdoHocKyIII_CheckedChanged);
            // 
            // rdoHocKyIV
            // 
            this.rdoHocKyIV.AutoSize = true;
            this.rdoHocKyIV.Location = new System.Drawing.Point(383, 190);
            this.rdoHocKyIV.Name = "rdoHocKyIV";
            this.rdoHocKyIV.Size = new System.Drawing.Size(40, 20);
            this.rdoHocKyIV.TabIndex = 14;
            this.rdoHocKyIV.TabStop = true;
            this.rdoHocKyIV.Text = "IV";
            this.rdoHocKyIV.UseVisualStyleBackColor = true;
            this.rdoHocKyIV.CheckedChanged += new System.EventHandler(this.rdoHocKyIV_CheckedChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(97, 329);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(87, 23);
            this.btnDangKy.TabIndex = 16;
            this.btnDangKy.Text = "Đăng &ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(223, 329);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(348, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 23);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "LT Windowns",
            "LT Internet",
            "Mạng máy tính",
            "UML"});
            this.clbMonHoc.Location = new System.Drawing.Point(142, 227);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(247, 72);
            this.clbMonHoc.TabIndex = 19;
            // 
            // bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 414);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.rdoHocKyIV);
            this.Controls.Add(this.rdoHocKyIII);
            this.Controls.Add(this.rdoHocKyII);
            this.Controls.Add(this.rdoHocKyI);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cboNienKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai11";
            this.Text = "bai11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.RadioButton rdoHocKyI;
        private System.Windows.Forms.RadioButton rdoHocKyII;
        private System.Windows.Forms.RadioButton rdoHocKyIII;
        private System.Windows.Forms.RadioButton rdoHocKyIV;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
    }
}