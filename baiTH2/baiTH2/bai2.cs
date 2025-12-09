using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
            // Khi form load, chọn mặc định radVietnam và ảnh đầu tiên
            radVietnam.Checked = true;
            pictureBox1.Image = imageList1.Images[0];
        }

        private void bai2_Load(object sender, EventArgs e)
        {

        }

        private void radVietnam_CheckedChanged(object sender, EventArgs e)
        {
            if (radVietnam.Checked)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (radUSA.Checked)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
        }

        private void radItalian_CheckedChanged(object sender, EventArgs e)
        {
            if (radItalian.Checked)
            {
                pictureBox1.Image = imageList1.Images[2];
            }
        }

        private void radPhilippine_CheckedChanged(object sender, EventArgs e)
        {
            if (radPhilippine.Checked)
            {
                pictureBox1.Image = imageList1.Images[3];
            }
        }
    }
}