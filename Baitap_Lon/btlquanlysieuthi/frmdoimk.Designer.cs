namespace btlquanlysieuthi
{
    partial class frmdoimk
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
            txtMatKhauMoi = new TextBox();
            txtXacNhanMK = new TextBox();
            cbQuyen = new ComboBox();
            btnCapNhat = new Button();
            txtMatKhauCu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkHienMatKhau = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(192, 96);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(157, 27);
            txtMatKhauMoi.TabIndex = 1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(192, 146);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(157, 27);
            txtXacNhanMK.TabIndex = 2;
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(165, 212);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(160, 28);
            cbQuyen.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(33, 11, 97);
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(26, 260);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(323, 56);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "đổi mật khẩu";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(192, 52);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(157, 27);
            txtMatKhauCu.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 55);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 6;
            label1.Text = "Mật Khẩu Cũ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 99);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu Mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 149);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 8;
            label3.Text = "Xác nhận lại mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 215);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 9;
            label4.Text = "Quyền Hạn:";
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(165, 179);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(188, 24);
            chkHienMatKhau.TabIndex = 10;
            chkHienMatKhau.Text = "Hiện Mật Khẩu Hiện Tại";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(chkHienMatKhau);
            groupBox1.Controls.Add(txtMatKhauMoi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtXacNhanMK);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbQuyen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatKhauCu);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(224, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 347);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi Mật Khẩu TK:";
            // 
            // frmdoimk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 530);
            Controls.Add(groupBox1);
            Name = "frmdoimk";
            Text = "frmdoimk";
            Load += frmdoimk_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMK;
        private ComboBox cbQuyen;
        private Button btnCapNhat;
        private TextBox txtMatKhauCu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkHienMatKhau;
        private GroupBox groupBox1;
    }
}