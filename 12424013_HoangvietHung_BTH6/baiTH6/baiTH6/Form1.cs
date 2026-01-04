using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel; // Cần add reference

namespace QuanLyDiem
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối (Sửa lại Server Name của bạn cho đúng)
        string strConn = @"LAPTOP-4LQHUV4V\SQLEXPRESS;Initial Catalog=UTEHY;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            LoadComboBoxes();
        }

        // 1. Hàm load dữ liệu vào ComboBox Môn và Lớp
        private void LoadComboBoxes()
        {
            try
            {
                SqlDataAdapter daMon = new SqlDataAdapter("SELECT * FROM MonHoc", conn);
                DataTable dtMon = new DataTable();
                daMon.Fill(dtMon);
                cboMon.DataSource = dtMon;
                cboMon.DisplayMember = "TenMH";
                cboMon.ValueMember = "MaMH";

                SqlDataAdapter daLop = new SqlDataAdapter("SELECT * FROM LopHoc", conn);
                DataTable dtLop = new DataTable();
                daLop.Fill(dtLop);
                cboLop.DataSource = dtLop;
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // 2. Button Nạp dữ liệu: Hiển thị danh sách sinh viên + Điểm (nếu có)
        // Yêu cầu: Sắp xếp theo Tên, sau đó đến Họ
        private void btnNap_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMon.SelectedValue == null) return;

            string maLop = cboLop.SelectedValue.ToString();
            string maMon = cboMon.SelectedValue.ToString();

            // Câu lệnh SQL quan trọng: LEFT JOIN để lấy cả SV chưa có điểm
            string sql = @"
                SELECT 
                    s.MaSV AS [Mã], 
                    s.Ho AS [Họ], 
                    s.Ten AS [Tên], 
                    d.DiemSo AS [Điểm]
                FROM SV s
                LEFT JOIN Diem d ON s.MaSV = d.MaSV AND d.MaMH = @MaMH
                WHERE s.MaLop = @MaLop
                ORDER BY s.Ten ASC, s.Ho ASC";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaMH", maMon);
                da.SelectCommand.Parameters.AddWithValue("@MaLop", maLop);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDiem.DataSource = dt;

                // Cho phép sửa cột Điểm, các cột khác chỉ đọc
                dgvDiem.Columns["Mã"].ReadOnly = true;
                dgvDiem.Columns["Họ"].ReadOnly = true;
                dgvDiem.Columns["Tên"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // 3. Button Lưu: Cập nhật điểm vào Database
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            string maMon = cboMon.SelectedValue.ToString();

            foreach (DataGridViewRow row in dgvDiem.Rows)
            {
                if (row.Cells["Mã"].Value != null) // Bỏ qua dòng trống cuối cùng
                {
                    string maSV = row.Cells["Mã"].Value.ToString();
                    object diemVal = row.Cells["Điểm"].Value;

                    // Nếu điểm trống thì bỏ qua hoặc xóa điểm cũ (tùy logic), ở đây ta chỉ lưu nếu có điểm
                    if (diemVal != null && diemVal.ToString() != "")
                    {
                        float diem = float.Parse(diemVal.ToString());

                        // Kiểm tra xem đã có điểm chưa để INSERT hoặc UPDATE
                        // Cách đơn giản nhất: Xóa cái cũ insert cái mới (hoặc dùng MERGE trong SQL)
                        string sqlCheck = "SELECT COUNT(*) FROM Diem WHERE MaSV=@MaSV AND MaMH=@MaMH";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                        cmdCheck.Parameters.AddWithValue("@MaSV", maSV);
                        cmdCheck.Parameters.AddWithValue("@MaMH", maMon);
                        int count = (int)cmdCheck.ExecuteScalar();

                        string sqlExec = "";
                        if (count > 0)
                            sqlExec = "UPDATE Diem SET DiemSo=@Diem WHERE MaSV=@MaSV AND MaMH=@MaMH";
                        else
                            sqlExec = "INSERT INTO Diem (MaSV, MaMH, DiemSo) VALUES (@MaSV, @MaMH, @Diem)";

                        SqlCommand cmd = new SqlCommand(sqlExec, conn);
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMon);
                        cmd.Parameters.AddWithValue("@Diem", diem);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            conn.Close();
            MessageBox.Show("Đã lưu bảng điểm thành công!");
        }

        // 4. Button Xuất Excel (Tạo Report)
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvDiem.Rows.Count == 0) return;

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook wb = excelApp.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];

            // Tiêu đề
            ws.Cells[1, 1] = "DANH SÁCH ĐIỂM SINH VIÊN";
            ws.Cells[2, 1] = "Lớp: " + cboLop.Text + " - Môn: " + cboMon.Text;

            // Header cột
            for (int i = 0; i < dgvDiem.Columns.Count; i++)
            {
                ws.Cells[4, i + 1] = dgvDiem.Columns[i].HeaderText;
            }

            // Dữ liệu
            for (int i = 0; i < dgvDiem.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvDiem.Columns.Count; j++)
                {
                    ws.Cells[i + 5, j + 1] = dgvDiem.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Kẻ bảng (Optional)
            ws.Range["A4", "D" + (dgvDiem.Rows.Count + 3)].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}