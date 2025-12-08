using System;
using System.Windows.Forms;

namespace baithuchanh1
{
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        private void bai8_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void ValidateInputs()
        {
            bool A = double.TryParse(txtNhapA.Text, out _);
            bool B = double.TryParse(txtNhapB.Text, out _);

            errorProvider1.SetError(txtNhapA, "");
            errorProvider1.SetError(txtNhapB, "");

            if (!A)
                errorProvider1.SetError(txtNhapA, "Phải nhập số hợp lệ cho A");
            if (!B)
                errorProvider1.SetError(txtNhapB, "Phải nhập số hợp lệ cho B");

            btnGiai.Enabled = A && B;
        }

        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
        private void txtNghiempt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNhapA.Text);
            double b = double.Parse(txtNhapB.Text);

            string ketqua;

            if (a == 0)
            {
                if (b == 0)
                    ketqua = "Phương trình có vô số nghiệm.";
                else
                    ketqua = "Phương trình vô nghiệm.";
            }
            else
            {
                double x = -b / a;
                ketqua = $"Phương trình có nghiệm x = {x}";
            }

            txtNghiempt.Text = ketqua;

            btnXoa.Enabled = true;
            btnGiai.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtNhapB.Clear();
            txtNghiempt.Clear();

            errorProvider1.Clear();

            btnXoa.Enabled = false;
            btnGiai.Enabled = false;

            txtNhapA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
