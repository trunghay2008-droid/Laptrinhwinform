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
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            Nhapchu();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked)
                txtNhap.Font = new Font("Arial", txtNhap.Font.Size);
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3.Checked)
                txtNhap.Font = new Font("Tahoma", txtNhap.Font.Size);
            DoiMau();
            DoiSize();
        }

        private void rad4_CheckedChanged(object sender, EventArgs e)
        {
            if (rad4.Checked)
                txtNhap.Font = new Font("Courier New", txtNhap.Font.Size);

        }
        private void DoiMau()
        {
            if (rad3.Checked)
                txtNhap.ForeColor = Color.Blue;
        }
        private void DoiSize()
        {
            if (rad3.Checked)
                txtNhap.Font = new Font(txtNhap.Font.FontFamily, 10);

        }
        private void Nhapchu()
        {

            if (rad1.Checked)
                txtNhap.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}