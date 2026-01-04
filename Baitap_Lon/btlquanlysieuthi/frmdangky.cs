using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class frmdangky : Form
    {
        string connStr = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        public frmdangky()
        {
            InitializeComponent();

        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string password = txtPassword.Text;
            string rePassword = txtRePassword.Text;
            string quyen = cbQuyen.SelectedItem.ToString();

            if (username == "" || tenNV == "" || password == "" || rePassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (password != rePassword)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    SqlCommand checkUser = new SqlCommand(
                        "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@u",
                        conn, tran);
                    checkUser.Parameters.AddWithValue("@u", username);

                    if ((int)checkUser.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        tran.Rollback();
                        return;
                    }
                    int maNV = TaoMaNV(conn, tran);
                    SqlCommand insertNV = new SqlCommand(@"
                    INSERT INTO NhanVien (MaNV, TenNV, Quyen, NgayVaoLam)
                    VALUES (@MaNV, @TenNV, @Quyen, GETDATE())", conn, tran);
                    insertNV.Parameters.AddWithValue("@MaNV", maNV);
                    insertNV.Parameters.AddWithValue("@TenNV", tenNV);
                    insertNV.Parameters.AddWithValue("@Quyen", quyen);
                    insertNV.ExecuteScalar();


                    SqlCommand insertTK = new SqlCommand(@"
                   INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen, MaNV)
                   VALUES (@User, @Pass, @Quyen, @MaNV)",
                        conn, tran);
                    insertTK.Parameters.AddWithValue("@User", username);
                    insertTK.Parameters.AddWithValue("@Pass", password);
                    insertTK.Parameters.AddWithValue("@Quyen", quyen);
                    insertTK.Parameters.AddWithValue("@MaNV", maNV);
                    insertTK.ExecuteNonQuery();
                    tran.Commit();
                    MessageBox.Show("Đăng ký thành công!");
                    txtUsername.Clear();
                    txtTenNV.Clear();
                    txtPassword.Clear();
                    txtRePassword.Clear();
                    cbQuyen.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi đăng ký: " + ex.Message);
                }
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkHienMatKhau.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtRePassword.UseSystemPasswordChar = !show;
        }

        int TaoMaNV(SqlConnection conn, SqlTransaction tran)
        {
            Random rd = new Random();
            int maNV;

            do
            {
                maNV = rd.Next(100, 999);

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV",
                    conn, tran);

                cmd.Parameters.AddWithValue("@MaNV", maNV);

                if ((int)cmd.ExecuteScalar() == 0)
                    return maNV;

            } while (true);
        }
        private void frmdangky_Load(object sender, EventArgs e)
        {

            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("quanly");
            cbQuyen.Items.Add("nhanvien");
            cbQuyen.SelectedIndex = 1;
            // Mặc định ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = true;
            txtRePassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin loginForm = new frmlogin();
            loginForm.Show();
            this.Hide();
        }
    }
}

