namespace BaiTH4
{
    partial class quản_lý_nhân_viên
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
            splitContainer1 = new SplitContainer();
            dgvNhanVien = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnTimKiem = new Button();
            label8 = new Label();
            label7 = new Label();
            txtTimKiem = new TextBox();
            cboTieuChiTimKiem = new ComboBox();
            groupBox2 = new GroupBox();
            btnthoat = new Button();
            btnxoanv = new Button();
            btnsuanv = new Button();
            btntaomoi = new Button();
            groupBox1 = new GroupBox();
            cboQuyen = new ComboBox();
            txtMatKhau = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTenDN = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtMa = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvNhanVien);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(791, 717);
            splitContainer1.SplitterDistance = 129;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Margin = new Padding(3, 4, 3, 4);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(791, 129);
            dgvNhanVien.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa chỉ ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tên đăng nhập";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mật khẩu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Quyền hạn";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(cboTieuChiTimKiem);
            groupBox3.Location = new Point(395, 343);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(268, 187);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(103, 122);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 42);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 87);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 18;
            label8.Text = "thể loại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 40);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 17;
            label7.Text = "nhập từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(114, 29);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(137, 27);
            txtTimKiem.TabIndex = 16;
            // 
            // cboTieuChiTimKiem
            // 
            cboTieuChiTimKiem.FormattingEnabled = true;
            cboTieuChiTimKiem.Location = new Point(113, 76);
            cboTieuChiTimKiem.Margin = new Padding(3, 4, 3, 4);
            cboTieuChiTimKiem.Name = "cboTieuChiTimKiem";
            cboTieuChiTimKiem.Size = new Size(138, 28);
            cboTieuChiTimKiem.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnthoat);
            groupBox2.Controls.Add(btnxoanv);
            groupBox2.Controls.Add(btnsuanv);
            groupBox2.Controls.Add(btntaomoi);
            groupBox2.Location = new Point(453, 20);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(143, 315);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(24, 199);
            btnthoat.Margin = new Padding(3, 4, 3, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(106, 31);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxoanv
            // 
            btnxoanv.Location = new Point(24, 149);
            btnxoanv.Margin = new Padding(3, 4, 3, 4);
            btnxoanv.Name = "btnxoanv";
            btnxoanv.Size = new Size(106, 31);
            btnxoanv.TabIndex = 7;
            btnxoanv.Text = "Xóa nhân viên";
            btnxoanv.UseVisualStyleBackColor = true;
            // 
            // btnsuanv
            // 
            btnsuanv.Location = new Point(24, 84);
            btnsuanv.Margin = new Padding(3, 4, 3, 4);
            btnsuanv.Name = "btnsuanv";
            btnsuanv.Size = new Size(106, 31);
            btnsuanv.TabIndex = 6;
            btnsuanv.Text = "Sửa NV";
            btnsuanv.UseVisualStyleBackColor = true;
            // 
            // btntaomoi
            // 
            btntaomoi.Location = new Point(24, 29);
            btntaomoi.Margin = new Padding(3, 4, 3, 4);
            btntaomoi.Name = "btntaomoi";
            btntaomoi.Size = new Size(106, 31);
            btntaomoi.TabIndex = 5;
            btntaomoi.Text = "tạo mới";
            btntaomoi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyen);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenDN);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(386, 372);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cboQuyen
            // 
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Location = new Point(123, 325);
            cboQuyen.Margin = new Padding(3, 4, 3, 4);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(138, 28);
            cboQuyen.TabIndex = 12;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(125, 256);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(114, 27);
            txtMatKhau.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 336);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "quyền hạn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 267);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 10;
            label6.Text = "mật khẩu";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(125, 197);
            txtTenDN.Margin = new Padding(3, 4, 3, 4);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(114, 27);
            txtTenDN.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 208);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "tên đăng nhập";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(125, 148);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(114, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 159);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "địa chỉ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(123, 93);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(114, 27);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(125, 31);
            txtMa.Margin = new Padding(3, 4, 3, 4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(114, 27);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // quản_lý_nhân_viên
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 717);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "quản_lý_nhân_viên";
            Text = "quản_lý_nhân_viên";
            Load += quản_lý_nhân_viên_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private GroupBox groupBox2;
        private Button btnthoat;
        private Button btnxoanv;
        private Button btnsuanv;
        private Button btntaomoi;
        private GroupBox groupBox1;
        private ComboBox cboQuyen;
        private TextBox txtMatKhau;
        private Label label5;
        private Label label6;
        private TextBox txtTenDN;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnTimKiem;
        private Label label8;
        private Label label7;
        private TextBox txtTimKiem;
        private ComboBox cboTieuChiTimKiem;
    }
}