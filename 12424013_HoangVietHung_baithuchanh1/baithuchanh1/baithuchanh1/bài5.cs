using System;
using System.Drawing;
using System.Windows.Forms;

namespace baithuchanh1
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void bài5_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;      
            txtNhap.Focus();    
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhap.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhap.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhap.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhap.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhap.ForeColor = Color.Black;
            }
        }

        private void UpdateFont()
        {
            FontStyle style = FontStyle.Regular;

            if (chkdam.Checked)
                style |= FontStyle.Bold;

            if (chknghieng.Checked)
                style |= FontStyle.Italic;

            if (chkgachchan.Checked)
                style |= FontStyle.Underline;

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, style);
            txtNhap.Font = new Font(txtNhap.Font.Name, txtNhap.Font.Size, style);
        }

        private void chkdam_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chknghieng_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
