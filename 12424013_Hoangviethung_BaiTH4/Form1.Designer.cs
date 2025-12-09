namespace BaiTH4
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
            txtmk = new TextBox();
            txtdangnhap = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnDangnhap = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtmk
            // 
            txtmk.Location = new Point(121, 125);
            txtmk.Margin = new Padding(3, 4, 3, 4);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(273, 27);
            txtmk.TabIndex = 3;
            // 
            // txtdangnhap
            // 
            txtdangnhap.Location = new Point(121, 63);
            txtdangnhap.Margin = new Padding(3, 4, 3, 4);
            txtdangnhap.Name = "txtdangnhap";
            txtdangnhap.Size = new Size(273, 27);
            txtdangnhap.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmk);
            groupBox1.Controls.Add(txtdangnhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 37);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(425, 221);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 129);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 73);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(35, 293);
            btnDangnhap.Margin = new Padding(3, 4, 3, 4);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(102, 36);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // button1
            // 
            button1.Location = new Point(360, 293);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 365);
            Controls.Add(groupBox1);
            Controls.Add(btnDangnhap);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtmk;
        private TextBox txtdangnhap;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnDangnhap;
        private Button button1;
    }
}
