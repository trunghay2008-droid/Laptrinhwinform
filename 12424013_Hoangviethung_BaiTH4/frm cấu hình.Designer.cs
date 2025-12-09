namespace BaiTH4
{
    partial class frm_cấu_hình
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
            btnketnoi = new Button();
            txtTenData = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtTenMay = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rdoQuyenAccount = new RadioButton();
            rdoQuyenWindow = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnketnoi
            // 
            btnketnoi.Location = new Point(587, 60);
            btnketnoi.Margin = new Padding(3, 4, 3, 4);
            btnketnoi.Name = "btnketnoi";
            btnketnoi.Size = new Size(86, 31);
            btnketnoi.TabIndex = 23;
            btnketnoi.Text = "kết nối";
            btnketnoi.UseVisualStyleBackColor = true;
            btnketnoi.Click += btnketnoi_Click_1;
            // 
            // txtTenData
            // 
            txtTenData.Location = new Point(397, 97);
            txtTenData.Margin = new Padding(3, 4, 3, 4);
            txtTenData.Name = "txtTenData";
            txtTenData.Size = new Size(114, 27);
            txtTenData.TabIndex = 22;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(397, 152);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(114, 27);
            txtUserName.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(397, 216);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 27);
            txtPassword.TabIndex = 20;
            // 
            // txtTenMay
            // 
            txtTenMay.Location = new Point(397, 47);
            txtTenMay.Margin = new Padding(3, 4, 3, 4);
            txtTenMay.Name = "txtTenMay";
            txtTenMay.Size = new Size(114, 27);
            txtTenMay.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 227);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 18;
            label5.Text = "Pass";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 163);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 17;
            label4.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 108);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 16;
            label3.Text = "Tên Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 57);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 15;
            label2.Text = "Tên máy/IP";
            // 
            // rdoQuyenAccount
            // 
            rdoQuyenAccount.AutoSize = true;
            rdoQuyenAccount.Location = new Point(143, 103);
            rdoQuyenAccount.Margin = new Padding(3, 4, 3, 4);
            rdoQuyenAccount.Name = "rdoQuyenAccount";
            rdoQuyenAccount.Size = new Size(121, 24);
            rdoQuyenAccount.TabIndex = 14;
            rdoQuyenAccount.TabStop = true;
            rdoQuyenAccount.Text = "Quyền acount";
            rdoQuyenAccount.UseVisualStyleBackColor = true;
            // 
            // rdoQuyenWindow
            // 
            rdoQuyenWindow.AutoSize = true;
            rdoQuyenWindow.Location = new Point(143, 55);
            rdoQuyenWindow.Margin = new Padding(3, 4, 3, 4);
            rdoQuyenWindow.Name = "rdoQuyenWindow";
            rdoQuyenWindow.Size = new Size(131, 24);
            rdoQuyenWindow.TabIndex = 13;
            rdoQuyenWindow.TabStop = true;
            rdoQuyenWindow.Text = "Quyền Window";
            rdoQuyenWindow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 55);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 12;
            label1.Text = "quyền kết nối";
            label1.Click += label1_Click;
            // 
            // frm_cấu_hình
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 295);
            Controls.Add(btnketnoi);
            Controls.Add(txtTenData);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtTenMay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rdoQuyenAccount);
            Controls.Add(rdoQuyenWindow);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_cấu_hình";
            Text = "frmCauhinh";
            Load += frm_cấu_hình_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnketnoi;
        private TextBox txtTenData;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtTenMay;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdoQuyenAccount;
        private RadioButton rdoQuyenWindow;
        private Label label1;
    }
}