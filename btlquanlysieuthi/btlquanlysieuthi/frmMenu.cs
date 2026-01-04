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
    public partial class Form1 : Form
    {
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlCommandBuilder builder;
        string _quyen;
        int _maNV;
        string connStr;
        private FormC _sharedFormC = new FormC();

        public Form1(string quyen, int maNV, string connStr)
        {
            InitializeComponent();
            _quyen = quyen;
            _maNV = maNV;
            this.connStr = connStr;
            LoadData();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {

            if (currentFormChild != null)// dòng này là để tránh khi mwor nhiều tab thì mấy tab đè lên nhau để k về đc trang chủ ban đàu 
            {
                splitContainer1.Panel2.Controls.Remove(currentFormChild);
                currentFormChild.Hide();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(childForm);
            splitContainer1.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChamCong(string loai)
        {
            if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter da = new SqlDataAdapter("sp_ChamCong", conn);
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@MaNV", maNV);
                    da.SelectCommand.Parameters.AddWithValue("@Ngay", DateTime.Today);
                    da.SelectCommand.Parameters.AddWithValue("@Gio", DateTime.Now.TimeOfDay);
                    da.SelectCommand.Parameters.AddWithValue("@Loai", loai);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dgvHienThi.Columns.Contains("GioVao"))
                    {
                        dgvHienThi.Columns["GioVao"].DefaultCellStyle.Format = @"hh\:mm\:ss";
                    }

                    // Kiểm tra cột GioRa có tồn tại không
                    if (dgvHienThi.Columns.Contains("GioRa"))
                    {
                        dgvHienThi.Columns["GioRa"].DefaultCellStyle.Format = @"hh\:mm\:ss";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("chấm công: " + ex.Message);
            }
        }
        private void LoadLuongNhanVien(int? maNV, bool showLuong)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_TongLuongThang", conn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", maNV.HasValue ? (object)maNV.Value : DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHienThi.DataSource = dt;

                dgvHienThi.Columns["MaNV"].HeaderText = "Mã user";
                dgvHienThi.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
                dgvHienThi.Columns["Quyen"].HeaderText = "Chức Vụ";
                dgvHienThi.Columns["TongCong"].HeaderText = "Tổng Công Tháng";
                dgvHienThi.Columns["TongLuong"].HeaderText = "Tổng Lương Tháng";
                if (showLuong)
                {
                    dgvHienThi.Columns["TongLuong"].HeaderText = "Tổng Lương Tháng";
                    dgvHienThi.Columns["TongLuong"].Visible = true;
                }
                else
                {
                    // Ẩn cột Tổng Lương khi không muốn hiển thị
                    if (dgvHienThi.Columns.Contains("TongLuong"))
                        dgvHienThi.Columns["TongLuong"].Visible = false;
                }
                dgvHienThi.AutoResizeColumns();
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            currentFormChild.Hide();
        }
        private void FormA_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormA(_sharedFormC));
        }

        private void FormC_Click(object sender, EventArgs e)
        {
            OpenChildForm(_sharedFormC);
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            ChamCong("VAO");
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ChamCong("RA");
        }
        private void btnTinhCongLuong_Click(object sender, EventArgs e)
        {

            if (_quyen.ToLower() != "admin")
            {
                MessageBox.Show("chờ cuối tháng sếp phát lương nhé," +
                    " chỉ có admin mới có thể tính lương!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMaNV.Text.Trim(), out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ");
                return;
            }

            LoadLuongNhanVien(maNV, showLuong: true);
        }
        private void btnXemTongCong_Click(object sender, EventArgs e)
        {
            LoadLuongNhanVien(null, showLuong: false);
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM NhanVien";
            SqlConnection conn = new SqlConnection(connStr);
            da = new SqlDataAdapter(sql, conn);
            builder = new SqlCommandBuilder(da);

            dt = new DataTable();
            da.Fill(dt);
            dgvHienThi.DataSource = dt;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra rỗng và định dạng số của Mã NV ngay lập tức
                if (!int.TryParse(txtMaNV.Text.Trim(), out int maMoi))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ (phải là số và không được để trống)!", "Thông báo");
                    return;
                }
                // Kiểm tra trùng mã trong bộ nhớ để tránh crash lỗi Primary Key
                foreach (DataRow r in dt.Rows)
                {
                    if (r.RowState != DataRowState.Deleted && Convert.ToInt32(r["MaNV"]) == maMoi)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại!", "Lỗi");
                        return;
                    }
                }
                DataRow newRow = dt.NewRow();
                newRow["MaNV"] = int.Parse(txtMaNV.Text);
                newRow["TenNV"] = txtTenNV.Text;
                newRow["GioiTinh"] = txtGioiTinh.Text;
                newRow["NgaySinh"] = DateTime.Parse(txtNgaySinh.Text);
                newRow["DienThoai"] = txtDienThoai.Text;
                newRow["Quyen"] = cbQuyen.SelectedItem?.ToString();
                newRow["NgayVaoLam"] = DateTime.Parse(txtNgayVaoLam.Text);
                newRow["Luong"] = decimal.Parse(txtLuong.Text);
                dt.Rows.Add(newRow);
                da.Update(dt);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin nhập vào không hợp lệ hoặc lỗi kết nối: ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("admin");
            cbQuyen.Items.Add("quanly");
            cbQuyen.Items.Add("nhanvien");
            cbQuyen.SelectedIndex = 0;
            dgvHienThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHienThi.MultiSelect = false;            //full dòng dgv 

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHienThi.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ danh sách!", "Thông báo");
                    return;
                }
                DataRowView rowView = (DataRowView)dgvHienThi.CurrentRow.DataBoundItem;
                DataRow row = rowView.Row;
                row["TenNV"] = txtTenNV.Text;
                row["GioiTinh"] = txtGioiTinh.Text;
                row["NgaySinh"] = DateTime.Parse(txtNgaySinh.Text);
                row["DienThoai"] = txtDienThoai.Text;
                row["Quyen"] = cbQuyen.SelectedItem?.ToString();
                row["NgayVaoLam"] = DateTime.Parse(txtNgayVaoLam.Text);
                row["Luong"] = decimal.Parse(txtLuong.Text);

                da.Update(dt);
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ: ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHienThi.CurrentRow == null || dgvHienThi.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng click chọn dòng nhân viên cần xóa trên bảng!", "Thông báo");
                    return; // Dừng lại không xóa
                }
                DataRowView rowView = (DataRowView)dgvHienThi.CurrentRow.DataBoundItem;
                rowView.Row.Delete();
                da.Update(dt);
                MessageBox.Show("Đã xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:bạn chưa chọn dòng để xóa ");
            }
        }
        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHienThi.AutoResizeColumns();
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvHienThi.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtTenNV.Text = row.Cells["TenNV"].Value?.ToString() ?? "";
            txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
            txtNgaySinh.Text = row.Cells["NgaySinh"].Value?.ToString() ?? "";
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
            string quyen = row.Cells["Quyen"].Value?.ToString() ?? "";
            cbQuyen.SelectedItem = quyen;
            txtNgayVaoLam.Text = row.Cells["NgayVaoLam"].Value?.ToString() ?? "";
            txtLuong.Text = row.Cells["Luong"].Value?.ToString() ?? "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (cc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmlogin loginForm = new frmlogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnfrmdoimk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmdoimk(this._maNV, this._quyen));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Gọi Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("sp_TimNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHienThi.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmqlkho());
        }
    }
}