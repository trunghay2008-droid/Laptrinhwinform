using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KTTHwinform
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=qlSP;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            cbLoaiSP.SelectedIndexChanged += cbLoaiSP_SelectedIndexChanged;
            dgvHienThiSP.CellClick += dgvHienThiSP_CellClick;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnHienThiLoai.Click += btnHienThiLoai_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxLoai();
            HienThiSanPham();
        }




        //Câu 1 nhập liệu vào cơ sở dữ liệu vs 2 bảng Category vs Product
        private void LoadComboBoxLoai()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    string query = "SELECT CategoryID, CategoryName FROM Category";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        dt.Rows.Add(1, "Đồ ăn");
                        dt.Rows.Add(2, "Thức uống");
                    }

                    DataRow dr = dt.NewRow();
                    dr["CategoryID"] = 0;
                    dr["CategoryName"] = "Tất cả ";
                    dt.Rows.InsertAt(dr, 0);

                    cbLoaiSP.DataSource = dt;
                    cbLoaiSP.DisplayMember = "CategoryName";
                    cbLoaiSP.ValueMember = "CategoryID";
                    cbLoaiSP.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load loại sản phẩm: " + ex.Message);
            }
        }
        // hàm hiển thị sản phẩm , tất cả , giá sản phẩm, tăng dần và giamr dần
        private void HienThiSanPham(int categoryId = 0, decimal? giaLoc = null, string sapXep = "NONE")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    string query = "SELECT ProductID, ProductName, Price, Quantity, CategoryID FROM Product WHERE 1=1";

                    if (categoryId != 0)
                        query += " AND CategoryID = @categoryId";

                    if (giaLoc != null)
                        query += " AND Price = @giaLoc";

                    if (sapXep == "ASC")
                        query += " ORDER BY Price ASC";
                    else if (sapXep == "DESC")
                        query += " ORDER BY Price DESC";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (categoryId != 0)
                            cmd.Parameters.AddWithValue("@categoryId", categoryId);

                        if (giaLoc != null)
                            cmd.Parameters.AddWithValue("@giaLoc", giaLoc);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHienThiSP.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sản phẩm: " + ex.Message);
            }
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSP.SelectedValue != null && int.TryParse(cbLoaiSP.SelectedValue.ToString(), out int categoryId))
            {
                HienThiSanPham(categoryId);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();

        }

        private bool ValidateInputs(bool isAdd)
        {
            if (isAdd)
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm không được để trống.");
                    txtMaSP.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.");
                txtTenSP.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGia.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ.");
                txtGia.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                txtSoLuong.Focus();
                return false;
            }

            if (cbLoaiSP.SelectedValue == null || (int)cbLoaiSP.SelectedValue == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                cbLoaiSP.Focus();
                return false;
            }

            return true;
        }





        //Câu 2 thêm chức năng  hiển thị sản phẩm , thêm /sửa/xóa
        // Thêm sản phẩm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(true)) return;

            try
            {
                int maSP = int.Parse(txtMaSP.Text.Trim());

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    // Kiểm tra trùng ProductID
                    string checkQuery = "SELECT COUNT(*) FROM Product WHERE ProductID = @id";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@id", maSP);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại, vui lòng chọn mã khác.");
                            return;
                        }
                    }

                    string query = "INSERT INTO Product (ProductID, ProductName, Price, Quantity, CategoryID) " +
                                   "VALUES (@id, @name, @price, @qty, @catId)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", maSP);
                        cmd.Parameters.AddWithValue("@name", txtTenSP.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtGia.Text.Trim()));
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtSoLuong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@catId", (int)cbLoaiSP.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm sản phẩm thành công!");
                HienThiSanPham((int)cbLoaiSP.SelectedValue);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
                return;
            }

            if (!ValidateInputs(false)) return;

            try
            {
                int maSP = int.Parse(txtMaSP.Text.Trim());

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    string query = "UPDATE Product SET ProductName=@name, Price=@price, Quantity=@qty, CategoryID=@catId WHERE ProductID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", maSP);
                        cmd.Parameters.AddWithValue("@name", txtTenSP.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtGia.Text.Trim()));
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtSoLuong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@catId", (int)cbLoaiSP.SelectedValue);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để sửa.");
                            return;
                        }
                    }
                }
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                HienThiSanPham((int)cbLoaiSP.SelectedValue);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                int maSP = int.Parse(txtMaSP.Text.Trim());

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    string query = "DELETE FROM Product WHERE ProductID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", maSP);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                            return;
                        }
                    }
                }
                MessageBox.Show("Xóa sản phẩm thành công!");
                HienThiSanPham((int)cbLoaiSP.SelectedValue);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

        private void dgvHienThiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHienThiSP.Rows.Count > 0)
            {
                DataGridViewRow row = dgvHienThiSP.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["ProductID"].Value.ToString();
                txtTenSP.Text = row.Cells["ProductName"].Value.ToString();
                txtGia.Text = row.Cells["Price"].Value.ToString();
                txtSoLuong.Text = row.Cells["Quantity"].Value.ToString();

                if (int.TryParse(row.Cells["CategoryID"].Value.ToString(), out int catId))
                {
                    cbLoaiSP.SelectedValue = catId;
                }
            }
        }

        // Nút hiện thị tất cả loại, nếu muốn sắp xếp thì 
        private void btnHienThiLoai_Click(object sender, EventArgs e)
        {
            cbLoaiSP.SelectedValue = 0;
            HienThiSanPham(0);
            ClearInputs();
        }

















        //CÂU 3
        //lọc giá từ txt giá(lọc theo giá trị X), lọc theo giá tăng dần giảm dần
        private void btnLocGia_Click(object sender, EventArgs e)
        {
            int categoryId = 0;
            if (cbLoaiSP.SelectedValue != null && int.TryParse(cbLoaiSP.SelectedValue.ToString(), out int catId))
                categoryId = catId;

            decimal? giaLoc = null;
            if (decimal.TryParse(txtGia.Text.Trim(), out decimal gia))
                giaLoc = gia;
            else if (!string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ để lọc!");
                txtGia.Focus();
                return;
            }

            HienThiSanPham(categoryId, giaLoc, "NONE");
        }


        // lọc theo giá tăng dần và giảm dần
        private void btnTangDan_Click(object sender, EventArgs e)
        {
            int categoryId = 0;
            HienThiSanPham(categoryId, null, "ASC");
        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            int categoryId = 0;
            HienThiSanPham(categoryId, null, "DESC");
        }
    }
}
