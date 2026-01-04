namespace KTTHwinform
{
    partial class Form1
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
            cbLoaiSP = new ComboBox();
            txtTenSP = new TextBox();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            dgvHienThiSP = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHienThiLoai = new Button();
            txtMaSP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLocGia = new Button();
            btnTangDan = new Button();
            btnGiamDan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHienThiSP).BeginInit();
            SuspendLayout();
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(100, 17);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(151, 28);
            cbLoaiSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(100, 112);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(151, 27);
            txtTenSP.TabIndex = 1;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(100, 154);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(151, 27);
            txtGia.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(105, 202);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(146, 27);
            txtSoLuong.TabIndex = 3;
            // 
            // dgvHienThiSP
            // 
            dgvHienThiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThiSP.Location = new Point(24, 250);
            dgvHienThiSP.Name = "dgvHienThiSP";
            dgvHienThiSP.RowHeadersWidth = 51;
            dgvHienThiSP.Size = new Size(702, 188);
            dgvHienThiSP.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(306, 11);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(179, 41);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(306, 60);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(179, 41);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(306, 112);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(179, 41);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHienThiLoai
            // 
            btnHienThiLoai.Location = new Point(306, 171);
            btnHienThiLoai.Name = "btnHienThiLoai";
            btnHienThiLoai.Size = new Size(179, 41);
            btnHienThiLoai.TabIndex = 8;
            btnHienThiLoai.Text = "Hiển Thị Theo Loại";
            btnHienThiLoai.UseVisualStyleBackColor = true;
            btnHienThiLoai.Click += btnHienThiLoai_Click;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(100, 60);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(151, 27);
            txtMaSP.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 10;
            label1.Text = "Loại SP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 11;
            label2.Text = "Mã SP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 112);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "Tên SP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 157);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 13;
            label4.Text = "Giá :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 202);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Số Lượng:";
            // 
            // btnLocGia
            // 
            btnLocGia.Location = new Point(544, 11);
            btnLocGia.Name = "btnLocGia";
            btnLocGia.Size = new Size(94, 29);
            btnLocGia.TabIndex = 15;
            btnLocGia.Text = "Lọc Giá";
            btnLocGia.UseVisualStyleBackColor = true;
            btnLocGia.Click += btnLocGia_Click;
            // 
            // btnTangDan
            // 
            btnTangDan.Location = new Point(544, 60);
            btnTangDan.Name = "btnTangDan";
            btnTangDan.Size = new Size(176, 29);
            btnTangDan.TabIndex = 16;
            btnTangDan.Text = "Lọc theo giá tăng dần";
            btnTangDan.UseVisualStyleBackColor = true;
            btnTangDan.Click += btnTangDan_Click;
            // 
            // btnGiamDan
            // 
            btnGiamDan.Location = new Point(544, 111);
            btnGiamDan.Name = "btnGiamDan";
            btnGiamDan.Size = new Size(176, 29);
            btnGiamDan.TabIndex = 17;
            btnGiamDan.Text = "Lọc Theo giá giảm dần";
            btnGiamDan.UseVisualStyleBackColor = true;
            btnGiamDan.Click += btnGiamDan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGiamDan);
            Controls.Add(btnTangDan);
            Controls.Add(btnLocGia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaSP);
            Controls.Add(btnHienThiLoai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvHienThiSP);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(txtTenSP);
            Controls.Add(cbLoaiSP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHienThiSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbLoaiSP;
        private TextBox txtTenSP;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private DataGridView dgvHienThiSP;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHienThiLoai;
        private TextBox txtMaSP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLocGia;
        private Button btnTangDan;
        private Button btnGiamDan;
    }
}