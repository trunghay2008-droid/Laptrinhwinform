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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtMaSV.Text = dataGridView1.Rows[rowIndex].Cells["MaSV"].Value.ToString();
                txtMaSV.Text = dataGridView1.Rows[rowIndex].Cells["HoTen"].Value.ToString();
                txtQueQuan.Text = dataGridView1.Rows[rowIndex].Cells["QueQuan"].Value.ToString();

            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || txtHoTen.Text == "" || txtQueQuan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            dataGridView1.Rows.Add(txtMaSV.Text, txtHoTen.Text, txtQueQuan.Text);

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtQueQuan.Clear();

        }

        private void bai5_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                selectedRow.Cells[0].Value = txtMaSV.Text; 
                selectedRow.Cells[1].Value = txtHoTen.Text; 
                selectedRow.Cells[2].Value = txtQueQuan.Text; 

                MessageBox.Show("Sửa thông tin sinh viên thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!");
            }
        }
    

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    txtMaSV.Clear();
                    txtHoTen.Clear();
                    txtQueQuan.Clear();

                    MessageBox.Show("Xóa sinh viên thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!");
            }
        }
     

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maSVCanTim = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(maSVCanTim))
            {
                MessageBox.Show("Vui lòng nhập Mã SV cần tìm vào ô Mã SV.");
                return;
            }

            dataGridView1.ClearSelection();
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string maSVTrongBang = row.Cells["MaSV"].Value.ToString();

                if (maSVTrongBang.Equals(maSVCanTim, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    found = true;
                    MessageBox.Show($"Đã tìm thấy sinh viên có Mã SV: {maSVCanTim}");

                    txtMaSV.Text = maSVTrongBang;
                    txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                    txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();

                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show($"Không tìm thấy sinh viên có Mã SV: {maSVCanTim}");
            }
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}