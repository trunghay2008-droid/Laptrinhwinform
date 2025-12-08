using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithuchanh1
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCong_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void rbtnTru_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();

        }

        private void rbtnNhan_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void rbtnChia_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }
        private void TinhToan()
        {
            double so1, so2;

            if (!double.TryParse(txtSo1.Text, out so1))
                return;
            if (!double.TryParse(txtSo2.Text, out so2))
                return;

            double kq = 0;

            if (rbtnCong.Checked)
                kq = so1 + so2;
            else if (rbtnTru.Checked)
                kq = so1 - so2;
            else if (rbtnNhan.Checked)
                kq = so1 * so2;
            else if (rbtnChia.Checked)
            {
                if (so2 == 0)
                {
                    txtKQ.Text = "0";
                    return;
                }
                kq = so1 / so2;
            }

            txtKQ.Text = kq.ToString();
        }

        private void bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
