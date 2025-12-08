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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {

            // Kiểm tra tên vs năn sinh
            if (txtYourName.Text.Length == 0)
            {
                MessageBox.Show("ghi tên vào đây");
                txtYourName.Focus();
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("ghi số năm sinh vào đây!");
                txtYear.Focus();
                return;
            }

                int age = DateTime.Now.Year - year;
            string s = "My name is: " + txtYourName.Text +
                       "\nMy age: " + age.ToString();

            MessageBox.Show(s, "tuổi bạn là");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            errorProvider1.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "m chác là thoát chứ",
        "Exit",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
