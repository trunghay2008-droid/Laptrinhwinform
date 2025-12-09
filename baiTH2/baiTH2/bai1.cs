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
    public partial class bai1 : Form
    {
        int i = 20;
        public bai1()
        {
            InitializeComponent();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            i = 20;
            lblDongHo.Text = i.ToString();
            timer1.Enabled = true;
        }

        private void bai1_Load(object sender, EventArgs e)
        {
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);

        }

        private void lblDongHo_Click(object sender, EventArgs e)
        {

        }



        private void btnDung_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = i.ToString();

            i--;

            if (i < 0)
            {
                timer1.Enabled = false;
                lblDongHo.Text = "Hết giờ!";
            }
        }
    }
}

