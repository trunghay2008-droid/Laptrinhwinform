using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BaiTH3
{
    public partial class quanlynhanvien : Form
    {
        public quanlynhanvien()
        {
      
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quản_lý_nhân_viên_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns.Clear();
            dgvNhanVien.Columns.Add("MaNV", "Mã NV");
            dgvNhanVien.Columns.Add("TenNV", "Tên NV");
            dgvNhanVien.Columns.Add("DIACHI", "Địa chỉ");
            dgvNhanVien.Columns.Add("TenDN", "Tên đăng nhập");
            dgvNhanVien.Columns.Add("MATKHAU", "Mật khẩu");
            dgvNhanVien.Columns.Add("QUYENHAN", "Quyền hạn");

            // Nạp quyền hạn
            cboQuyen.Items.Clear();
            cboQuyen.Items.Add("Quản trị");
            cboQuyen.Items.Add("Nhân viên");
            cboQuyen.SelectedIndex = 0;

            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadData();
        }
        private void LoadData()
        {
            dgvNhanVien.Rows.Clear();

            Program.Db.Open();
            string sql = "SELECT MaNV, TenNV,DIACHI, TenDN, MATKHAU, QUYENHAN FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sql, Program.Db.Connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvNhanVien.Rows.Add(
                    dr["MaNV"].ToString(),
                    dr["TenNV"].ToString(),
                    dr["DIACHI"].ToString(),
                    dr["TenDN"].ToString(),
                    dr["MATKHAU"].ToString(),
                    dr["QUYENHAN"].ToString()
                );
            }

            dr.Close();
            Program.Db.Close();
        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvNhanVien.Rows[e.RowIndex];

            txtMa.Text = r.Cells["MaNV"].Value?.ToString();
            txtTen.Text = r.Cells["TenNV"].Value?.ToString();
            txtDiaChi.Text = r.Cells["DIACHI"].Value?.ToString();
            txtTenDN.Text = r.Cells["TenDN"].Value?.ToString();
            txtMatKhau.Text = r.Cells["MATKHAU"].Value?.ToString();
            cboQuyen.Text = r.Cells["QUYENHAN"].Value?.ToString();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO NhanVien(MaNV, TenNV,DIACHI, TenDN, MATKHAU, QUYENHAN) " +
             "VALUES (@ma, @ten, @dc, @TenDN, @mk, @qh)";

            try
            {
                Program.Db.Open();
                SqlCommand cmd = new SqlCommand(sql, Program.Db.Connection);
                cmd.Parameters.AddWithValue("@ma", txtMa.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text.Trim());
                cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text.Trim());
                cmd.Parameters.AddWithValue("@qh", cboQuyen.Text.Trim());

                int n = cmd.ExecuteNonQuery();
                Program.Db.Close();

                if (n > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Program.Db.Close();
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NhanVien SET TenNV=@ten,DIACHI=@dc, TenDN=@TenDN, " +
            "MATKHAU=@mk, QUYENHAN=@qh WHERE MaNV=@ma";

            try
            {
                Program.Db.Open();
                SqlCommand cmd = new SqlCommand(sql, Program.Db.Connection);
                cmd.Parameters.AddWithValue("@ma", txtMa.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text.Trim());
                cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text.Trim());
                cmd.Parameters.AddWithValue("@qh", cboQuyen.Text.Trim());

                int n = cmd.ExecuteNonQuery();
                Program.Db.Close();

                if (n > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Program.Db.Close();
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string sql = "DELETE FROM NhanVien WHERE MaNV=@ma";

            try
            {
                Program.Db.Open();
                SqlCommand cmd = new SqlCommand(sql, Program.Db.Connection);
                cmd.Parameters.AddWithValue("@ma", txtMa.Text.Trim());

                int n = cmd.ExecuteNonQuery();
                Program.Db.Close();

                if (n > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Program.Db.Close();
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
