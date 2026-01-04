using Microsoft.Data.SqlClient;
using System;
using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace btlquanlysieuthi
{
    public partial class FormC : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";

        public FormC()
        {
            InitializeComponent();
            // Khi form mở lên thì nạp sản phẩm ngay
            this.Load += (s, e) => LoadCardsFromSQL();
            LoadCardsFromSQL();
            LoadNhanVien();
        }
        public void LoadCardsFromSQL()
        {
            flpProductList.Controls.Clear();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string query = "SELECT * FROM Product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Khởi tạo Card từ FormB
                    FormB card = new FormB();     // sau đó Đổ dữ liệu từ SQL vào Card
                    card.SetData(
                        dr["ProductID"].ToString(),
                        dr["ProductName"].ToString(),
                        (decimal)dr["Price"],
                        (int)dr["Quantity"],
                        dr["ImagePath"]?.ToString()
                    );
                    //sự kiện click ở card
                    card.OnAddClick += (id, name, price, qty) =>
                    {
                        ThemSanPhamVaoGrid(id, name, price, qty);
                    };
                    flpProductList.Controls.Add(card);
                }
            }
        }
        private void ThemSanPhamVaoGrid(string id, string name, decimal price, int qty)
        {

            bool isExist = false;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[0].Value?.ToString() == id)
                {
                    int currentQty = int.Parse(row.Cells[2].Value.ToString());
                    int newQty = currentQty + qty;
                    row.Cells[2].Value = newQty;
                    row.Cells[4].Value = newQty * price;
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                dgvOrder.Rows.Add(id, name, qty, price, qty * price);
            }
            TinhTongTien();
        }
        private void TinhTongTien()// nó sẽ lấy từ cột dgv
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[4].Value != null)
                    total += (decimal)row.Cells[4].Value;
            }
            lblTotal.Text = "Tổng cộng: " + total.ToString("N0") + " VNĐ";
        }

        private void btnOpenFormA_Click(object sender, EventArgs e)
        {

        }
        private void LoadNhanVien()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string query = "SELECT MaNV, TenNV FROM NhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbNhanVien.DataSource = dt;
                    cbNhanVien.DisplayMember = "TenNV"; // Hiển thị tên
                    cbNhanVien.ValueMember = "MaNV";    // Giá trị thực tế là mã
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải NV: " + ex.Message); }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count == 0) // Kiểm tra giỏ hàng trống
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng!");
                return;
            }
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction(); // Đảm bảo an toàn dữ liệu khi lưu nhiều bảng

                try
                {
                    string sqlOrder = @"INSERT INTO Orders (OrderDate, MaNV, MaKH, TotalAmount) 
                                VALUES (GETDATE(), @maNV, @maKH, @total);
                                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdOrder = new SqlCommand(sqlOrder, con, trans);
                    cmdOrder.Parameters.AddWithValue("@maNV", cbNhanVien.SelectedValue);
                    cmdOrder.Parameters.AddWithValue("@maKH", 1);
                    decimal totalVal = decimal.Parse(lblTotal.Text.Replace("Tổng cộng: ", "").Replace(" VNĐ", "").Trim());
                    cmdOrder.Parameters.AddWithValue("@total", totalVal);
                    int newOrderID = Convert.ToInt32(cmdOrder.ExecuteScalar());
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[0].Value != null)
                        {
                            // Chèn vào bảng OrderDetails
                            string sqlDetail = @"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) 
                                         VALUES (@oid, @pid, @qty, @price)";
                            SqlCommand cmdDetail = new SqlCommand(sqlDetail, con, trans);
                            cmdDetail.Parameters.AddWithValue("@oid", newOrderID);
                            cmdDetail.Parameters.AddWithValue("@pid", row.Cells[0].Value); 
                            cmdDetail.Parameters.AddWithValue("@qty", row.Cells[2].Value); 
                            cmdDetail.Parameters.AddWithValue("@price", row.Cells[3].Value);
                            cmdDetail.ExecuteNonQuery();
                            // trừ số lượng tồn kho sau khi mua
                            string sqlUpdateStock = "UPDATE Product SET Quantity = Quantity - @qty WHERE ProductID = @pid";
                            SqlCommand cmdUpdate = new SqlCommand(sqlUpdateStock, con, trans);
                            cmdUpdate.Parameters.AddWithValue("@qty", row.Cells[2].Value);
                            cmdUpdate.Parameters.AddWithValue("@pid", row.Cells[0].Value);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();//lưu kq quá trình thực thi
                    MessageBox.Show("Thanh toán thành công! Mã đơn hàng của bạn là: " + newOrderID);

                    LoadCardsFromSQL();
                    this.Tag = newOrderID;
                    dgvOrder.Rows.Clear();
                    lblTotal.Text = "Tổng cộng: 0 VNĐ";
                }
                catch (Exception ex)
                {
                    trans.Rollback(); 
                    MessageBox.Show("Lỗi trong quá trình thanh toán: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null && !dgvOrder.CurrentRow.IsNewRow)
            {
                try
                {
                    DataGridViewRow row = dgvOrder.CurrentRow;
                    if (row.Cells[2].Value == null || !int.TryParse(row.Cells[2].Value.ToString(), out int newQty) || newQty <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên > 0)!");
                        return;
                    }
                    decimal unitPrice = Convert.ToDecimal(row.Cells[3].Value);
                    row.Cells[4].Value = newQty * unitPrice;
                    TinhTongTien();

                    MessageBox.Show("Đã cập nhật đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong bảng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null && !dgvOrder.CurrentRow.IsNewRow)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvOrder.Rows.Remove(dgvOrder.CurrentRow);
                    TinhTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                MessageBox.Show("Vui lòng thực hiện thanh toán trước khi in hóa đơn!");
                return;
            }
            //Truy vấn dữ liệu từ SQL dựa trên Mã hóa đơn (maHD)
            string maHD = this.Tag.ToString();
            string nhanVien = cbNhanVien.Text;
            string tenKhachHang = txtTenKH.Text;
            string hoaDon = "---------- HÓA ĐƠN SIÊU THỊ ----------\n";
            hoaDon += $"Mã đơn hàng: {maHD}\n";
            hoaDon += $"Khách hàng:  {tenKhachHang}\n";
            hoaDon += $"Ngày:        {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n";
            hoaDon += $"Nhân viên:   {nhanVien}\n";
            hoaDon += "--------------------------------------\n";
            hoaDon += string.Format("{0,-20} {1,-5} {2,-10}\n", "Tên SP", "SL", "Thành tiền");

            decimal tongTienTuDB = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string query = @"SELECT ProductName, Quantity, ThanhTien
                     FROM v_ChiTietHoaDon
                     WHERE OrderID = @maHD";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@maHD", maHD);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string ten = dr["ProductName"].ToString();
                        string sl = dr["Quantity"].ToString();
                        decimal tt = Convert.ToDecimal(dr["ThanhTien"]);
                        tongTienTuDB += tt;
                        if (ten.Length > 20) ten = ten.Substring(0, 17) + "...";

                        hoaDon += string.Format("{0,-20} {1,-5} {2,-10}\n", ten, sl, tt.ToString("N0"));
                    }
                }
                hoaDon += "--------------------------------------\n";
                hoaDon += $"Tổng cộng: {tongTienTuDB.ToString("N0")} VNĐ\n";
                hoaDon += "---------- CẢM ƠN QUÝ KHÁCH ----------";
                string folderPath = Path.Combine(Application.StartupPath, "HoaDon");
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                string filePath = Path.Combine(folderPath, $"HD_{maHD}.txt");
                File.WriteAllText(filePath, hoaDon, System.Text.Encoding.UTF8);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy chi tiết hóa đơn: " + ex.Message);
            }
        }
        }
}

 
