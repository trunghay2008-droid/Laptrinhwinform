using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithuchanh1
{
    public partial class bai11 : Form
    {
        public bai11()
        {
            InitializeComponent();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoHocKyI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoHocKyII_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoHocKyIII_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoHocKyIV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboNienKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Niên khóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoTen = txtHoTen.Text;
            string lop = cboLop.SelectedItem.ToString();
            string nienKhoa = cboNienKhoa.SelectedItem.ToString();
            string hocKy = "";

            if (rdoHocKyI.Checked) hocKy = "I";
            else if (rdoHocKyII.Checked) hocKy = "II";
            else if (rdoHocKyIII.Checked) hocKy = "III";

            if (hocKy == "")
            {
                MessageBox.Show("Vui lòng chọn Học kỳ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder sb = new StringBuilder();
            int i = 1;

            foreach (var mh in clbMonHoc.CheckedItems)
                sb.AppendLine($"{i++}. {mh}");

            string thongTin =
                $"Sinh viên: {hoTen}\n" +
                $"Lớp: {lop}\n" +
                $"Niên khóa: {nienKhoa}\n" +
                $"Đăng ký học kỳ: {hocKy}\n" +
                $"Số môn đăng ký: {clbMonHoc.CheckedItems.Count}\n" +
                $"Danh sách môn:\n{sb}";

            MessageBox.Show(thongTin, "ĐĂNG KÝ THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
