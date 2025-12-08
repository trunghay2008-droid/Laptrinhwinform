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
    public partial class bai9 : Form
    {
        public bai9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int so;

            if (!int.TryParse(txtNhap.Text, out so))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi");
                txtNhap.SelectAll();
                return;
            }

            listBox1.Items.Add(so);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach (var item in listBox1.Items)
            {
                int so;
                if (int.TryParse(item.ToString(), out so))
                    tong += so;
            }

            MessageBox.Show("Tổng các phần tử = " + tong);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;

            listBox1.Items.RemoveAt(0);

            if (listBox1.Items.Count > 0)
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn 1 phần tử để xóa!");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int so;
                if (int.TryParse(listBox1.Items[i].ToString(), out so))
                {
                    listBox1.Items[i] = so + 2;
                }
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int so;
                if (int.TryParse(listBox1.Items[i].ToString(), out so))
                {
                    listBox1.Items[i] = so * so;
                }
            }
        }

        private void btnChonChan_Click(object sender, EventArgs e)
        {
            List<int> chan = new List<int>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int so;
                if (int.TryParse(listBox1.Items[i].ToString(), out so))
                {
                    if (so % 2 == 0)
                        chan.Add(so);
                }
            }
            listBox1.Items.Clear();
            foreach (var x in chan)
                listBox1.Items.Add(x);
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            List<int> le = new List<int>();

            // Lấy tất cả số lẻ
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int so;
                if (int.TryParse(listBox1.Items[i].ToString(), out so))
                {
                    if (so % 2 != 0)
                        le.Add(so);
                }
            }
            listBox1.Items.Clear();
            foreach (var x in le)
                listBox1.Items.Add(x);
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
