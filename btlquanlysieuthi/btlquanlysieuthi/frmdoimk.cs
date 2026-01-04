using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class frmdoimk : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        int _maNV;      // Lưu mã nhân viên từ Form chính truyền sang
        string _quyen;   // Lưu quyền từ Form chính truyền sang

        public frmdoimk(int maNV, string quyen)
        {
            InitializeComponent();
            this._maNV = maNV;
            this._quyen = quyen;
            txtMatKhauCu.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) || string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu!", "Thông báo");
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp!", "Lỗi");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    // Kiểm tra mật khẩu cũ có đúng không
                    string sqlCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNV = @ma AND MatKhau = @mkCu";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
                    cmdCheck.Parameters.AddWithValue("@ma", _maNV);
                    cmdCheck.Parameters.AddWithValue("@mkCu", txtMatKhauCu.Text.Trim());

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        string quyenMoi = cbQuyen.SelectedItem?.ToString() ?? _quyen;
                        string sqlUpdate = "UPDATE TaiKhoan SET MatKhau = @mkMoi, Quyen = @quyen WHERE MaNV = @ma";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);
                        cmdUpdate.Parameters.AddWithValue("@mkMoi", txtMatKhauMoi.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@quyen", quyenMoi);
                        cmdUpdate.Parameters.AddWithValue("@ma", _maNV);

                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật mật khẩu và quyền thành công!", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi bảo mật");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống:Thông báo lỗi");
            }
        }

        private void frmdoimk_Load(object sender, EventArgs e)
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("admin");
            cbQuyen.Items.Add("quanly");
            cbQuyen.Items.Add("nhanvien");
            cbQuyen.SelectedItem = _quyen;
            if (_quyen.ToLower() != "admin")
            {
                cbQuyen.Enabled = false;
            }
        }
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = false;
            txtMatKhauMoi.UseSystemPasswordChar = false;
            txtXacNhanMK.UseSystemPasswordChar = false;
        }
    }
}
