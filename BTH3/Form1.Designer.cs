namespace BaiTH3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtmk = new TextBox();
            txtdangnhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            btndn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmk);
            groupBox1.Controls.Add(txtdangnhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtmk
            // 
            txtmk.Location = new Point(106, 94);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(239, 23);
            txtmk.TabIndex = 3;
            // 
            // txtdangnhap
            // 
            txtdangnhap.Location = new Point(106, 47);
            txtdangnhap.Name = "txtdangnhap";
            txtdangnhap.Size = new Size(239, 23);
            txtdangnhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 55);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // button1
            // 
            button1.Location = new Point(317, 228);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 1;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btndn
            // 
            btndn.Location = new Point(33, 228);
            btndn.Name = "btndn";
            btndn.Size = new Size(89, 27);
            btndn.TabIndex = 2;
            btndn.Text = "Đăng nhập";
            btndn.UseVisualStyleBackColor = true;
            btndn.Click += btndn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 274);
            Controls.Add(btndn);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Đăng nhập hệ thống";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtmk;
        private TextBox txtdangnhap;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btndn;
    }
}
