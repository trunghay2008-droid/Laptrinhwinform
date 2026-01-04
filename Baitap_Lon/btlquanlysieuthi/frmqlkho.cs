using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class frmqlkho : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";

        public frmqlkho()
        {
            InitializeComponent();
            this.Load += Frmqlkho_Load;
        }

        private void Frmqlkho_Load(object sender, EventArgs e)
        {
            LoadDataKho();
            LoadComboBoxLoai();
            HienThiLoiNhuan();
        }
        private void LoadDataKho()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    string sql = "SELECT * FROM v_ThongTinKho";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKho.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu từ View: " + ex.Message);
            }
        }

        private void HienThiLoiNhuan()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT SUM(TienLai) FROM v_LoiNhuanHoaDonst";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    object res = cmd.ExecuteScalar();

                    decimal tongLai = (res != DBNull.Value && res != null) ? Convert.ToDecimal(res) : 0;

                    lblLoiNhuan.Text = $"TỔNG LỢI NHUẬN THU VỀ: {tongLai:N0} VNĐ";
                    lblLoiNhuan.ForeColor = Color.DarkGreen;
                }
            }
            catch { lblLoiNhuan.Text = "Lợi nhuận: 0 VNĐ"; }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_NhapHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tenNCC", txtTenNCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenSP", txtTenSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@sl", int.Parse(txtSoLuong.Text));
                    cmd.Parameters.AddWithValue("@giaN", decimal.Parse(txtGiaNhap.Text));
                    cmd.Parameters.AddWithValue("@maLoai", cbLoaiSP.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nhập hàng thành công!");
                    LoadDataKho();
                    HienThiLoiNhuan();// Hàm gom LoadDataKho và HienThiLoiNhuan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SP và Số lượng!");
                return false;
            }
            if (!int.TryParse(txtSoLuong.Text, out _) || !decimal.TryParse(txtGiaNhap.Text, out _))
            {
                MessageBox.Show("Số lượng và Giá nhập phải là số!");
                return false;
            }
            return true;
        }


        private void LoadComboBoxLoai()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Category", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbLoaiSP.DataSource = dt;
                cbLoaiSP.DisplayMember = "CategoryName";
                cbLoaiSP.ValueMember = "CategoryID";
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    string sql = "SELECT * FROM v_ChiTietHoaDonst ORDER BY OrderID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Hiển thị lên DataGridView
                    dgvKho.DataSource = dt;

                    // Tùy chỉnh định dạng tiền tệ cho các cột giá cho đẹp
                    dgvKho.Columns["Giá Vốn"].DefaultCellStyle.Format = "N0";
                    dgvKho.Columns["Giá Bán"].DefaultCellStyle.Format = "N0";
                    dgvKho.Columns["Thành Tiền"].DefaultCellStyle.Format = "N0";
                    dgvKho.Columns["Lợi Nhuận"].DefaultCellStyle.Format = "N0";
                    // Tô màu cột Lợi Nhuận để dễ theo dõi
                    dgvKho.Columns["Lợi Nhuận"].DefaultCellStyle.ForeColor = Color.Red;
                    dgvKho.Columns["Lợi Nhuận"].DefaultCellStyle.Font = new Font(dgvKho.Font, FontStyle.Bold);

                    MessageBox.Show("Đã tải báo cáo chi tiết hóa đơn kèm giá nhập!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXemphieunhap_Click(object sender, EventArgs e)
        {
            LoadDataKho();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ bảng!");
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        string sql = "DELETE FROM Product WHERE ProductID = @id";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", txtMaSP.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        txtMaSP.Clear();
                        txtTenSP.Clear();
                        LoadDataKho();
                        HienThiLoiNhuan();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này vì đã có hóa đơn bán hàng liên quan!\nChi tiết: " + ex.Message);
                }
            }
        }




        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["ProductID"].Value.ToString();
                txtTenSP.Text = row.Cells["ProductName"].Value.ToString();

                if (row.Cells["GiaNhap"].Value != null)
                    txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                txtSoLuong.Text = row.Cells["TonKho"].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoaHoaDon_Click_1(object sender, EventArgs e)
        {
            if (dgvKho.CurrentRow == null || dgvKho.Columns.Contains("OrderID") == false)
            {
                MessageBox.Show("Vui lòng nhấn nút 'Xem Hóa Đơn' và chọn một hóa đơn để xóa!");
                return;
            }

            string maHD = dgvKho.CurrentRow.Cells["OrderID"].Value?.ToString();

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không tìm thấy Mã hóa đơn để xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa VĨNH VIỄN hóa đơn số: {maHD}?",
                                              "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        string sql = "DELETE FROM Orders WHERE OrderID = @id";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", maHD);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đã xóa hóa đơn thành công!");
                            btnXemHoaDon_Click(sender, e);
                            HienThiLoiNhuan();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }

            }
        }
    }
}