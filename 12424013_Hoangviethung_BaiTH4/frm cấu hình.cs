using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTH4
{
    public partial class frm_cấu_hình : Form
    {
        public frm_cấu_hình()
        {
            InitializeComponent();
        }

        private void frm_cấu_hình_Load(object sender, EventArgs e)
        {

            string quyen, sv, db, un, pw;
            DataHelper.ReadConfig("config.ini",
                                  out quyen, out sv, out db, out un, out pw);

            if (quyen == "WD")
                rdoQuyenWindow.Checked = true;
            else
                rdoQuyenAccount.Checked = true;

            txtTenMay.Text = sv;
            txtTenData.Text = db;
            txtUserName.Text = un;
            txtPassword.Text = pw;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnketnoi_Click_1(object sender, EventArgs e)
        {
            string quyen = rdoQuyenWindow.Checked ? "WD" : "AC";
            string sv = txtTenMay.Text.Trim();
            string db = txtTenData.Text.Trim();
            string un = txtUserName.Text.Trim();
            string pw = txtPassword.Text.Trim();

            try
            {
                DataHelper temp;
                if (quyen == "WD")
                    temp = new DataHelper(sv, db);
                else
                    temp = new DataHelper(sv, db, un, pw);

                temp.Open(); // thử kết nối
                temp.Close();

                // Ghi file
                DataHelper.WriteConfig("config.ini", quyen, sv, db, un, pw);

                MessageBox.Show("Kết nối thành công, đã lưu cấu hình.");

                // Gán cho Program.Db và mở Form đăng nhập
                Program.Db = temp;
                this.Hide();
                new Form1().ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);
                txtTenMay.Focus();
            }
        }
    }
}
