namespace BaiTH3
{
    partial class frmCauhinh
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
            label1 = new Label();
            rdoQuyenWindow = new RadioButton();
            rdoQuyenAccount = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenMay = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtTenData = new TextBox();
            btnketnoi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "quyền kết nối";
            // 
            // rdoQuyenWindow
            // 
            rdoQuyenWindow.AutoSize = true;
            rdoQuyenWindow.Location = new Point(119, 41);
            rdoQuyenWindow.Name = "rdoQuyenWindow";
            rdoQuyenWindow.Size = new Size(107, 19);
            rdoQuyenWindow.TabIndex = 1;
            rdoQuyenWindow.TabStop = true;
            rdoQuyenWindow.Text = "Quyền Window";
            rdoQuyenWindow.UseVisualStyleBackColor = true;
            // 
            // rdoQuyenAccount
            // 
            rdoQuyenAccount.AutoSize = true;
            rdoQuyenAccount.Location = new Point(119, 77);
            rdoQuyenAccount.Name = "rdoQuyenAccount";
            rdoQuyenAccount.Size = new Size(100, 19);
            rdoQuyenAccount.TabIndex = 2;
            rdoQuyenAccount.TabStop = true;
            rdoQuyenAccount.Text = "Quyền acount";
            rdoQuyenAccount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 43);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên máy/IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 122);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 5;
            label4.Text = "UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 170);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 6;
            label5.Text = "Pass";
            // 
            // txtTenMay
            // 
            txtTenMay.Location = new Point(341, 35);
            txtTenMay.Name = "txtTenMay";
            txtTenMay.Size = new Size(100, 23);
            txtTenMay.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(341, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(341, 114);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 9;
            // 
            // txtTenData
            // 
            txtTenData.Location = new Point(341, 73);
            txtTenData.Name = "txtTenData";
            txtTenData.Size = new Size(100, 23);
            txtTenData.TabIndex = 10;
            // 
            // btnketnoi
            // 
            btnketnoi.Location = new Point(508, 45);
            btnketnoi.Name = "btnketnoi";
            btnketnoi.Size = new Size(75, 23);
            btnketnoi.TabIndex = 11;
            btnketnoi.Text = "kết nối";
            btnketnoi.UseVisualStyleBackColor = true;
            btnketnoi.Click += btnketnoi_Click;
            // 
            // frm_cấu_hình
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 221);
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
            Name = "frm_cấu_hình";
            Text = "frm_cấu_hình";
            Load +=frmCauhinh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdoQuyenWindow;
        private RadioButton rdoQuyenAccount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenMay;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtTenData;
        private Button btnketnoi;
    }
}