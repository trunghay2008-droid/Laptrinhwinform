namespace baithuchanh1
{
    partial class bai3
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.cboKQDS = new System.Windows.Forms.ComboBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsoluongsnt = new System.Windows.Forms.Button();
            this.btnsoluongchan = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.listDSHT = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(6, 21);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(134, 28);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // cboKQDS
            // 
            this.cboKQDS.FormattingEnabled = true;
            this.cboKQDS.Location = new System.Drawing.Point(6, 67);
            this.cboKQDS.Name = "cboKQDS";
            this.cboKQDS.Size = new System.Drawing.Size(134, 24);
            this.cboKQDS.TabIndex = 2;
            this.cboKQDS.SelectedIndexChanged += new System.EventHandler(this.cboKQDS_SelectedIndexChanged);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(146, 21);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(82, 33);
            this.btnCapnhat.TabIndex = 3;
            this.btnCapnhat.Text = "&Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(70, 173);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 29);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKQDS);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // btnsoluongsnt
            // 
            this.btnsoluongsnt.Location = new System.Drawing.Point(18, 214);
            this.btnsoluongsnt.Name = "btnsoluongsnt";
            this.btnsoluongsnt.Size = new System.Drawing.Size(150, 35);
            this.btnsoluongsnt.TabIndex = 6;
            this.btnsoluongsnt.Text = "số lượng các ước số &nguyên tố";
            this.btnsoluongsnt.UseVisualStyleBackColor = true;
            this.btnsoluongsnt.Click += new System.EventHandler(this.btnsoluongsnt_Click);
            // 
            // btnsoluongchan
            // 
            this.btnsoluongchan.Location = new System.Drawing.Point(18, 160);
            this.btnsoluongchan.Name = "btnsoluongchan";
            this.btnsoluongchan.Size = new System.Drawing.Size(150, 35);
            this.btnsoluongchan.TabIndex = 5;
            this.btnsoluongchan.Text = "&số lượng các ước số chẵn";
            this.btnsoluongchan.UseVisualStyleBackColor = true;
            this.btnsoluongchan.Click += new System.EventHandler(this.btnsoluongchan_Click);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(18, 106);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(150, 35);
            this.btntong.TabIndex = 4;
            this.btntong.Text = "Tổng các ước số";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // listDSHT
            // 
            this.listDSHT.FormattingEnabled = true;
            this.listDSHT.ItemHeight = 16;
            this.listDSHT.Location = new System.Drawing.Point(18, 16);
            this.listDSHT.Name = "listDSHT";
            this.listDSHT.Size = new System.Drawing.Size(150, 84);
            this.listDSHT.TabIndex = 1;
            this.listDSHT.SelectedIndexChanged += new System.EventHandler(this.listDSHT_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listDSHT);
            this.groupBox2.Controls.Add(this.btntong);
            this.groupBox2.Controls.Add(this.btnsoluongchan);
            this.groupBox2.Controls.Add(this.btnsoluongsnt);
            this.groupBox2.Location = new System.Drawing.Point(264, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Name = "bai3";
            this.Text = "bai3cs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ComboBox cboKQDS;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsoluongsnt;
        private System.Windows.Forms.Button btnsoluongchan;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.ListBox listDSHT;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}