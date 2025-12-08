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
    public partial class bai10 : Form
    {
        public bai10()
        {
            InitializeComponent();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string ten = txtNhap.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Không được để trống!");
                return;
            }

            listBoxA.Items.Add(ten);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void listBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void btnchuyenphai_Click(object sender, EventArgs e)
        {
            MoveSelected(listBoxA, listBoxB);
        }

        private void btnchuyenallphai_Click(object sender, EventArgs e)
        {
            MoveAll(listBoxA, listBoxB);
        }

        private void btnchuyentrai_Click(object sender, EventArgs e)
        {
            MoveSelected(listBoxB, listBoxA);
        }

        private void btnchuyenalltrai_Click(object sender, EventArgs e)
        {
            MoveAll(listBoxB, listBoxA);
        }
        private void MoveAll(ListBox source, ListBox dest)
        {
            foreach (var item in source.Items)
                dest.Items.Add(item);

            source.Items.Clear();
        }
        private void MoveSelected(ListBox source, ListBox dest)
        {
            List<object> items = new List<object>();
            foreach (var item in source.SelectedItems)
                items.Add(item);

            foreach (var item in items)
                dest.Items.Add(item);

            foreach (var item in items)
                source.Items.Remove(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ////xóa all
            //listBoxA.Items.Clear();
            //listBoxB.Items.Clear();
            //xóa từng mục
            List<object> itemsToRemove = new List<object>();

            foreach (var item in listBoxA.SelectedItems)
                itemsToRemove.Add(item);
            foreach (var item in itemsToRemove)
                listBoxA.Items.Remove(item);
            foreach (var item in listBoxB.SelectedItems)
                itemsToRemove.Add(item);
            foreach (var item in itemsToRemove)
                listBoxB.Items.Remove(item);

        }
    }
}
