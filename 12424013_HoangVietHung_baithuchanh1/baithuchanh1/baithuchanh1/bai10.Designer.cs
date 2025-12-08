namespace baithuchanh1
{
    partial class bai10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxB = new System.Windows.Forms.ListBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnchuyenphai = new System.Windows.Forms.Button();
            this.btnchuyenallphai = new System.Windows.Forms.Button();
            this.btnchuyentrai = new System.Windows.Forms.Button();
            this.btnchuyenalltrai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxA);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.ItemHeight = 16;
            this.listBoxA.Location = new System.Drawing.Point(0, 21);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.Size = new System.Drawing.Size(137, 164);
            this.listBoxA.TabIndex = 0;
            this.listBoxA.SelectedIndexChanged += new System.EventHandler(this.listBoxA_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxB);
            this.groupBox2.Location = new System.Drawing.Point(252, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // listBoxB
            // 
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.ItemHeight = 16;
            this.listBoxB.Location = new System.Drawing.Point(6, 21);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.Size = new System.Drawing.Size(137, 164);
            this.listBoxB.TabIndex = 0;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(323, 55);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(78, 23);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "&Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnchuyenphai
            // 
            this.btnchuyenphai.Location = new System.Drawing.Point(161, 118);
            this.btnchuyenphai.Name = "btnchuyenphai";
            this.btnchuyenphai.Size = new System.Drawing.Size(75, 23);
            this.btnchuyenphai.TabIndex = 2;
            this.btnchuyenphai.Text = ">";
            this.btnchuyenphai.UseVisualStyleBackColor = true;
            this.btnchuyenphai.Click += new System.EventHandler(this.btnchuyenphai_Click);
            // 
            // btnchuyenallphai
            // 
            this.btnchuyenallphai.Location = new System.Drawing.Point(161, 157);
            this.btnchuyenallphai.Name = "btnchuyenallphai";
            this.btnchuyenallphai.Size = new System.Drawing.Size(75, 23);
            this.btnchuyenallphai.TabIndex = 3;
            this.btnchuyenallphai.Text = ">>";
            this.btnchuyenallphai.UseVisualStyleBackColor = true;
            this.btnchuyenallphai.Click += new System.EventHandler(this.btnchuyenallphai_Click);
            // 
            // btnchuyentrai
            // 
            this.btnchuyentrai.Location = new System.Drawing.Point(161, 198);
            this.btnchuyentrai.Name = "btnchuyentrai";
            this.btnchuyentrai.Size = new System.Drawing.Size(75, 23);
            this.btnchuyentrai.TabIndex = 4;
            this.btnchuyentrai.Text = "<";
            this.btnchuyentrai.UseVisualStyleBackColor = true;
            this.btnchuyentrai.Click += new System.EventHandler(this.btnchuyentrai_Click);
            // 
            // btnchuyenalltrai
            // 
            this.btnchuyenalltrai.Location = new System.Drawing.Point(161, 244);
            this.btnchuyenalltrai.Name = "btnchuyenalltrai";
            this.btnchuyenalltrai.Size = new System.Drawing.Size(75, 23);
            this.btnchuyenalltrai.TabIndex = 5;
            this.btnchuyenalltrai.Text = "<<";
            this.btnchuyenalltrai.UseVisualStyleBackColor = true;
            this.btnchuyenalltrai.Click += new System.EventHandler(this.btnchuyenalltrai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(52, 315);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(258, 315);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetthuc.TabIndex = 7;
            this.btnKetthuc.Text = "&Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(82, 55);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(235, 22);
            this.txtNhap.TabIndex = 8;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 387);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnchuyenphai);
            this.Controls.Add(this.btnchuyenallphai);
            this.Controls.Add(this.btnchuyentrai);
            this.Controls.Add(this.btnchuyenalltrai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai10";
            this.Text = "bai10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxB;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnchuyenphai;
        private System.Windows.Forms.Button btnchuyenallphai;
        private System.Windows.Forms.Button btnchuyentrai;
        private System.Windows.Forms.Button btnchuyenalltrai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.TextBox txtNhap;
    }
}