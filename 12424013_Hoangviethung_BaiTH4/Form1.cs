using System.Data;
using Microsoft.Data.SqlClient;

namespace BaiTH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdangnhap.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txtdangnhap.Text.Trim();
            string pass = txtmk.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Nhập tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {
                Program.Db.Open();

                string sql = "SELECT * FROM NhanVien " +
                             "WHERE TenDN = @user AND MatKhau = @pass";

                SqlCommand cmd = new SqlCommand(sql, Program.Db.Connection);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    Program.Db.Close();

                    this.Hide();
                    new quản_lý_nhân_viên().ShowDialog();
                    this.Close();
                }
                else
                {
                    dr.Close();
                    Program.Db.Close();
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
                    txtdangnhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}

