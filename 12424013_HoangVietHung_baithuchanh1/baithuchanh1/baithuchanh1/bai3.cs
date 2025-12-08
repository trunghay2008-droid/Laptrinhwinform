using System.Windows.Forms;
using System;

namespace baithuchanh1
{
    public partial class bai3 : Form
    {
        private int so = 0;  // khai báo biến toàn cục để lưu số nhập

        public bai3()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string input = txtNhap.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }

            if (!int.TryParse(input, out int so) || so <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }

            cboKQDS.Items.Add(so);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void LoadUocSoVaHienThi(int so)
        {
            listDSHT.Items.Clear();

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    listDSHT.Items.Add(i);
                }
            }
        }

        private bool LaNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            if (cboKQDS.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKQDS.Focus();
                return;
            }

            if (!int.TryParse(cboKQDS.SelectedItem.ToString(), out int so))
            {
                MessageBox.Show("Giá trị chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadUocSoVaHienThi(so);

            int tong = 0;
            foreach (int uoc in listDSHT.Items)
            {
                tong += uoc;
            }

            MessageBox.Show($"Tổng các ước số của {so} là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsoluongchan_Click(object sender, EventArgs e)
        {
            if (cboKQDS.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKQDS.Focus();
                return;
            }

            if (!int.TryParse(cboKQDS.SelectedItem.ToString(), out int so))
            {
                MessageBox.Show("Giá trị chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadUocSoVaHienThi(so);
            listDSHT.Items.Clear();

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0 && i % 2 == 0)
                {
                    listDSHT.Items.Add(i);
                }
            }
            int demChan = listDSHT.Items.Count;

            MessageBox.Show($"Số lượng các ước số chẵn của {so} là: {demChan}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnsoluongsnt_Click(object sender, EventArgs e)
        {
            if (cboKQDS.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKQDS.Focus();
                return;
            }

            if (!int.TryParse(cboKQDS.SelectedItem.ToString(), out int so))
            {
                MessageBox.Show("Giá trị chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadUocSoVaHienThi(so);
            listDSHT.Items.Clear();

            int demNguyenTo = 0;

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0 && LaNguyenTo(i))
                {
                    listDSHT.Items.Add(i);
                    demNguyenTo++;
                }
            }

            MessageBox.Show($"Số lượng các ước số nguyên tố của {so} là: {demNguyenTo}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboKQDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                    listDSHT.Items.Add(i);
            }
        }
        private void listDSHT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}