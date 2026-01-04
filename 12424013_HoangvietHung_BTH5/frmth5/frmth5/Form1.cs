using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity; 
namespace frmth5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sachdbEntities1 db = new sachdbEntities1();
        private bool isAdding = false;
        private bool isEditing = false;
        
        private void btnthem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            SetEditing(true);
            ClearInputs();
            txtMaSach.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadData();
            LoadCategories();
            LoadProducts();

            SetEditing(false);
        }

        private void SetEditing(bool isEditing)
        {
            txtMaSach.Enabled = isEditing;
            txtTieuDe.Enabled = isEditing;
            txtGia.Enabled = isEditing;
            txtSoLuong.Enabled = isEditing;

            btnLuu.Enabled = isEditing;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
        }
        private void ClearInputs()
        {
            txtMaSach.Clear();
            txtTieuDe.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
        }
        private void LoadCategories()
        {
            var categories = db.Categories
                .OrderBy(c => c.CategoryName)
                .Select(c => new { c.CategoryId, c.CategoryName })
                .ToList();

            cboLoaiSach.DataSource = categories;
            cboLoaiSach.DisplayMember = "CategoryName";
            cboLoaiSach.ValueMember = "CategoryId";
        }
        private void LoadProducts()
        {
            var products = db.Products
                .OrderBy(p => p.ProductCode)
                .Select(p => new
                {
                    p.ProductCode,
                    p.Description,
                    p.UnitPrice,
                    p.OnHandQuantity,
                    p.CategoryId
                })
                .ToList();

            dgvthongtinsach.DataSource = products;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Validate chung
            if (!decimal.TryParse(txtGia.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Don gia khong hop le!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("So luong khong hop le!");
                return;
            }

            
            if (isAdding)
            {
                string code = txtMaSach.Text.Trim();

                if (db.Products.Any(p => p.ProductCode == code))
                {
                    MessageBox.Show("Ma sach da ton tai!");
                    return;
                }

                var pNew = new Product
                {
                    ProductCode = code,
                    Description = txtTieuDe.Text.Trim(),
                    UnitPrice = price,
                    OnHandQuantity = qty,
                    CategoryId = (int)cboLoaiSach.SelectedValue
                };

                db.Products.Add(pNew);
                db.SaveChanges();

                MessageBox.Show("Them sach thanh cong!");
            }
           
            else if (isEditing)
            {
                string code = txtMaSach.Text.Trim();
                var p = db.Products.FirstOrDefault(x => x.ProductCode == code);

                if (p == null)
                {
                    MessageBox.Show("Khong tim thay sach!");
                    return;
                }

                p.Description = txtTieuDe.Text.Trim();
                p.UnitPrice = price;
                p.OnHandQuantity = qty;
                p.CategoryId = (int)cboLoaiSach.SelectedValue;

                db.SaveChanges();

                MessageBox.Show("Cap nhat thanh cong!");
            }

            // Reset trang thai
            isAdding = false;
            isEditing = false;

            LoadProducts();
            SetEditing(false);
        }

        private void dgvthongtinsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvthongtinsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvthongtinsach.Rows[e.RowIndex];

            txtMaSach.Text = row.Cells["ProductCode"].Value?.ToString();
            txtTieuDe.Text = row.Cells["Description"].Value?.ToString();
            txtGia.Text = row.Cells["UnitPrice"].Value?.ToString();
            txtSoLuong.Text = row.Cells["OnHandQuantity"].Value?.ToString();

            if (row.Cells["CategoryId"].Value != null)
                cboLoaiSach.SelectedValue = (int)row.Cells["CategoryId"].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string code = txtMaSach.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Hay chon 1 sach de xoa!");
                return;
            }

            var confirm = MessageBox.Show("Ban co chac muon xoa?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            var p = db.Products.FirstOrDefault(x => x.ProductCode == code);
            if (p == null)
            {
                MessageBox.Show("Khong tim thay sach can xoa!");
                return;
            }

            db.Products.Remove(p);
            db.SaveChanges();

            LoadProducts();
            ClearInputs();
            MessageBox.Show("Xoa thanh cong!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Chon sach can sua!");
                return;
            }

            isAdding = false;
            isEditing = true;

            SetEditing(true);
            txtMaSach.Enabled = false; // KHONG cho sua khoa
        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSach.SelectedValue == null) return;

            int categoryId;
            if (!int.TryParse(cboLoaiSach.SelectedValue.ToString(), out categoryId)) return;

            var products = db.Products
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new
                {
                    p.ProductCode,
                    p.Description,
                    p.UnitPrice,
                    p.OnHandQuantity,
                    p.CategoryId
                })
                .ToList();

            dgvthongtinsach.DataSource = products;
        }
    }
    
    //void LoadData()
    //{

    //    var danhSach = db.Products.ToList();
    //    dgvthongtinsach.DataSource = danhSach;
    //}
}

