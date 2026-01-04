using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace btlquanlysieuthi
{
    // Lưu ý: Để dùng làm Card, chúng ta sửa 'Form' thành 'UserControl' 
    public partial class FormB : UserControl
    {
        // Khai báo sự kiện để truyền dữ liệu sang FormC (Đơn hàng)
        public event Action<string, string, decimal, int> OnAddClick;
        private string _productID; // Biến tạm lưu ID sản phẩm
        public FormB()
        {
            InitializeComponent();
        }
        // Nhận dữ liệu từ FormA/SQL để hiển thị lên Card
        public void SetData(string id, string name, decimal price, int stock, string imgPath)
        {
            _productID = id;
            lblTenSP.Text = name;
            lblGia.Text = price.ToString("N0") + " VNĐ";
            lblStock.Text = "Số lượng tồn: " + stock.ToString();
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                try
                {
                    using (FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    {
                        picAnh.Image = Image.FromStream(fs);
                    }
                }
                catch { /* Xử lý nếu ảnh lỗi */ }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQty.Text, out int qty) && qty > 0)
            {
                OnAddClick?.Invoke(_productID, lblTenSP.Text, decimal.Parse(lblGia.Text.Replace(" VNĐ", "").Replace(",", "")), qty);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
            }
        }
    }
}