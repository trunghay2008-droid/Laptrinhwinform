using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class FormA : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        string selectedImagePath = "";
        private FormC _formBanHang;

        public FormA(FormC banHang)
        {
            InitializeComponent();
            this.Load += FormA_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnImport.Click += btnImport_Click;
            this._formBanHang = banHang;
        }

        private void FormA_Load(object sender, EventArgs e)
        {
            LoadComboBoxLoai();
            HienThiSanPham();
        }

        private void LoadComboBoxLoai()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string query = "SELECT * FROM Category";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbLoaiSP.DataSource = dt;
                    cbLoaiSP.DisplayMember = "CategoryName";
                    cbLoaiSP.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load danh mục: " + ex.Message); }
        }

        private void HienThiSanPham()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string query = "SELECT * FROM Product";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHienThiSP.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hiển thị bảng: " + ex.Message); }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = open.FileName;
                using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                {
                    picSP.Image = Image.FromStream(fs);
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên sản phẩm!");
                return false;
            }
            if (!decimal.TryParse(txtGia.Text, out _) || !int.TryParse(txtSoLuong.Text, out _))
            {
                MessageBox.Show("Giá và Số lượng phải là số hợp lệ!");
                return false;
            }
            return true;
        }

        private void SaveProduct(string action)
        {
            int soLuong = int.Parse(txtSoLuong.Text.Trim());
            string trangThai = soLuong > 0 ? "Còn hàng" : "Hết hàng";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Product_CRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", txtTenSP.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@Quantity", soLuong);
                cmd.Parameters.AddWithValue("@CategoryID", cbLoaiSP.SelectedValue);
                cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath);
                cmd.Parameters.AddWithValue("@Status", trangThai);

                cmd.ExecuteNonQuery();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {

                {
                    SaveProduct("INSERT");
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    txtGia.Text = "0";
                    txtSoLuong.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm:" + ex.Message); 
            }
            HienThiSanPham();
            if (_formBanHang != null)
            {
                _formBanHang.LoadCardsFromSQL();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                SaveProduct("UPDATE");
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                HienThiSanPham();
                if (_formBanHang != null)
                {
                    _formBanHang.LoadCardsFromSQL();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã sản phẩm cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        string query = "DELETE FROM Product WHERE ProductID=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", txtMaSP.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    HienThiSanPham();
                    // CẬP NHẬT CARD Ở FORMC
                    if (_formBanHang != null)
                    {
                        _formBanHang.LoadCardsFromSQL();
                    }
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }


        //===========================================================

    }
}