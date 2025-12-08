namespace baithuchanh1
{
    partial class bai4
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnChia = new System.Windows.Forms.RadioButton();
            this.rbtnNhan = new System.Windows.Forms.RadioButton();
            this.rbtnTru = new System.Windows.Forms.RadioButton();
            this.rbtnCong = new System.Windows.Forms.RadioButton();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(105, 22);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(334, 22);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(106, 56);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(334, 22);
            this.txtSo2.TabIndex = 1;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnChia);
            this.groupBox1.Controls.Add(this.rbtnNhan);
            this.groupBox1.Controls.Add(this.rbtnTru);
            this.groupBox1.Controls.Add(this.rbtnCong);
            this.groupBox1.Location = new System.Drawing.Point(49, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // rbtnChia
            // 
            this.rbtnChia.AutoSize = true;
            this.rbtnChia.Location = new System.Drawing.Point(276, 33);
            this.rbtnChia.Name = "rbtnChia";
            this.rbtnChia.Size = new System.Drawing.Size(55, 20);
            this.rbtnChia.TabIndex = 3;
            this.rbtnChia.TabStop = true;
            this.rbtnChia.Text = "Chia";
            this.rbtnChia.UseVisualStyleBackColor = true;
            this.rbtnChia.CheckedChanged += new System.EventHandler(this.rbtnChia_CheckedChanged);
            // 
            // rbtnNhan
            // 
            this.rbtnNhan.AutoSize = true;
            this.rbtnNhan.Location = new System.Drawing.Point(185, 33);
            this.rbtnNhan.Name = "rbtnNhan";
            this.rbtnNhan.Size = new System.Drawing.Size(60, 20);
            this.rbtnNhan.TabIndex = 2;
            this.rbtnNhan.TabStop = true;
            this.rbtnNhan.Text = "Nhân";
            this.rbtnNhan.UseVisualStyleBackColor = true;
            this.rbtnNhan.CheckedChanged += new System.EventHandler(this.rbtnNhan_CheckedChanged);
            // 
            // rbtnTru
            // 
            this.rbtnTru.AutoSize = true;
            this.rbtnTru.Location = new System.Drawing.Point(99, 33);
            this.rbtnTru.Name = "rbtnTru";
            this.rbtnTru.Size = new System.Drawing.Size(48, 20);
            this.rbtnTru.TabIndex = 1;
            this.rbtnTru.TabStop = true;
            this.rbtnTru.Text = "Trừ";
            this.rbtnTru.UseVisualStyleBackColor = true;
            this.rbtnTru.CheckedChanged += new System.EventHandler(this.rbtnTru_CheckedChanged);
            // 
            // rbtnCong
            // 
            this.rbtnCong.AutoSize = true;
            this.rbtnCong.Location = new System.Drawing.Point(6, 33);
            this.rbtnCong.Name = "rbtnCong";
            this.rbtnCong.Size = new System.Drawing.Size(60, 20);
            this.rbtnCong.TabIndex = 0;
            this.rbtnCong.TabStop = true;
            this.rbtnCong.Text = "Cộng";
            this.rbtnCong.UseVisualStyleBackColor = true;
            this.rbtnCong.CheckedChanged += new System.EventHandler(this.rbtnCong_CheckedChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(114, 214);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(326, 22);
            this.txtKQ.TabIndex = 3;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả:";
            // 
            // bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Name = "bai4";
            this.Text = "bai4";
            this.Load += new System.EventHandler(this.bai4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnChia;
        private System.Windows.Forms.RadioButton rbtnNhan;
        private System.Windows.Forms.RadioButton rbtnTru;
        private System.Windows.Forms.RadioButton rbtnCong;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}