namespace baiTH2
{
    partial class bai2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPhilippine = new System.Windows.Forms.RadioButton();
            this.radItalian = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.radVietnam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPhilippine);
            this.groupBox1.Controls.Add(this.radItalian);
            this.groupBox1.Controls.Add(this.radUSA);
            this.groupBox1.Controls.Add(this.radVietnam);
            this.groupBox1.Location = new System.Drawing.Point(21, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // radPhilippine
            // 
            this.radPhilippine.AutoSize = true;
            this.radPhilippine.Location = new System.Drawing.Point(16, 207);
            this.radPhilippine.Name = "radPhilippine";
            this.radPhilippine.Size = new System.Drawing.Size(87, 20);
            this.radPhilippine.TabIndex = 3;
            this.radPhilippine.TabStop = true;
            this.radPhilippine.Text = "Philippine";
            this.radPhilippine.UseVisualStyleBackColor = true;
            this.radPhilippine.CheckedChanged += new System.EventHandler(this.radPhilippine_CheckedChanged);
            // 
            // radItalian
            // 
            this.radItalian.AutoSize = true;
            this.radItalian.Location = new System.Drawing.Point(16, 150);
            this.radItalian.Name = "radItalian";
            this.radItalian.Size = new System.Drawing.Size(63, 20);
            this.radItalian.TabIndex = 2;
            this.radItalian.TabStop = true;
            this.radItalian.Text = "Italian";
            this.radItalian.UseVisualStyleBackColor = true;
            this.radItalian.CheckedChanged += new System.EventHandler(this.radItalian_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(16, 90);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(56, 20);
            this.radUSA.TabIndex = 1;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // radVietnam
            // 
            this.radVietnam.AutoSize = true;
            this.radVietnam.Location = new System.Drawing.Point(16, 37);
            this.radVietnam.Name = "radVietnam";
            this.radVietnam.Size = new System.Drawing.Size(83, 20);
            this.radVietnam.TabIndex = 0;
            this.radVietnam.TabStop = true;
            this.radVietnam.Text = "Việt Nam";
            this.radVietnam.UseVisualStyleBackColor = true;
            this.radVietnam.CheckedChanged += new System.EventHandler(this.radVietnam_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 216);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "VietNam.png");
            this.imageList1.Images.SetKeyName(1, "USA.png");
            this.imageList1.Images.SetKeyName(2, "Italian.png");
            this.imageList1.Images.SetKeyName(3, "Philippine.png");
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "bai2";
            this.Text = "bai2";
            this.Load += new System.EventHandler(this.bai2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPhilippine;
        private System.Windows.Forms.RadioButton radItalian;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radVietnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}