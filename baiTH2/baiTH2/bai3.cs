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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtLName.Text);
            it.SubItems.Add(txtFName.Text);
            it.SubItems.Add(txtPhone.Text);
            listView1.Items.Add(it);
            it.ImageIndex = 0;
            txtLName.Clear();
            txtFName.Clear();
            txtPhone.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bai3_Load(object sender, EventArgs e)
        {
            ImageList img = new ImageList();
            img.Images.Add(imageList1.Images[0]);
            listView1.SmallImageList = img;
        }
    }  
}
