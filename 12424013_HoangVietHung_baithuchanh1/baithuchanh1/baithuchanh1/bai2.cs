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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bai2_Load(object sender, EventArgs e)
        {

        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoten.Text.Trim();

            if (this.rad1.Checked == true)
                txtKQ.Text = hoten.ToLower();

            if (this.rad2.Checked == true)
                txtKQ.Text = hoten.ToUpper();
        }


        private void txtHienthi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoten.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = true;
            this.txtHoten.Focus();
        }
    }
}
