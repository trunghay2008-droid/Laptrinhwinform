using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH2
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || cboLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(dtNgaySinh.Text);
            item.SubItems.Add(cboLop.Text);

            item.ImageIndex = 0; // icon

            listView1.Items.Add(item);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng để cập nhật!", "Thông báo");
                return;
            }

            ListViewItem l = listView1.SelectedItems[0];

            l.SubItems[0].Text = txtMaSV.Text;
            l.SubItems[1].Text = txtHoTen.Text;
            l.SubItems[2].Text = txtDiaChi.Text;
            l.SubItems[3].Text = dtNgaySinh.Text;
            l.SubItems[4].Text = cboLop.Text;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem l = listView1.SelectedItems[0];

            txtMaSV.Text = l.SubItems[0].Text;
            txtHoTen.Text = l.SubItems[1].Text;
            txtDiaChi.Text = l.SubItems[2].Text;
            dtNgaySinh.Text = l.SubItems[3].Text;
            cboLop.Text = l.SubItems[4].Text;
        }

        private void bai4_Load(object sender, EventArgs e)
        {
            ImageList img = new ImageList();
            img.Images.Add(imageList1.Images[0]);
            listView1.SmallImageList = img;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}