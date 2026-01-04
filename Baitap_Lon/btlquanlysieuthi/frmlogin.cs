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


    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn quyền");
                return;
            }

            string connStr = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT Quyen, MaNV, TenNV
                             FROM vw_DangNhap
                             WHERE TenDangNhap = @user
                             AND MatKhau = @pass
                             AND Quyen = @quyen";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@quyen", cboQuyen.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string quyen = dt.Rows[0]["Quyen"].ToString();
                    int maNV = Convert.ToInt32(dt.Rows[0]["MaNV"]);

                    MessageBox.Show("Đăng nhập thành công (" + quyen + ")");

                    Form1 f = new Form1(quyen, maNV, connStr);

                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản / mật khẩu / quyền");
                }
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            cboQuyen.Items.Add("admin");
            cboQuyen.Items.Add("quanly");
            cboQuyen.Items.Add("nhanvien");

            cboQuyen.SelectedIndex = 0;
            txtPass.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmdangky loginForm = new frmdangky();
            loginForm.Show();
            this.Hide();
        }
    }
}
