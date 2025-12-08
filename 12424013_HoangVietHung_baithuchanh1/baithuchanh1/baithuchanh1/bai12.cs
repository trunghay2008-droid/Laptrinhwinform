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
    public partial class bai12 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;
        public bai12()
        {
            InitializeComponent();
        }

        private void txtManHinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void bai12_Load(object sender, EventArgs e)
        {
            btn0.Click += btnNumber_Click;
            btn1.Click += btnNumber_Click;
            btn2.Click += btnNumber_Click;
            btn3.Click += btnNumber_Click;
            btn4.Click += btnNumber_Click;
            btn5.Click += btnNumber_Click;
            btn6.Click += btnNumber_Click;
            btn7.Click += btnNumber_Click;
            btn8.Click += btnNumber_Click;
            btn9.Click += btnNumber_Click;
            btnCham.Click += btnNumber_Click;

            // Gán sự kiện chung cho nút phép toán
            btnCong.Click += btnOperator_Click;
            btnTru.Click += btnOperator_Click;
            btnNhan.Click += btnOperator_Click;
            btnChia.Click += btnOperator_Click;
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtManHinh.Text == "0" || operationPressed)
                txtManHinh.Clear();

            operationPressed = false;

            Button b = (Button)sender;
            txtManHinh.Text += b.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            operation = b.Text;
            value = double.Parse(txtManHinh.Text);
            operationPressed = true;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            {
                double secondValue = double.Parse(txtManHinh.Text);

                switch (operation)
                {
                    case "+":
                        txtManHinh.Text = (value + secondValue).ToString();
                        break;
                    case "-":
                        txtManHinh.Text = (value - secondValue).ToString();
                        break;
                    case "*":
                        txtManHinh.Text = (value * secondValue).ToString();
                        break;
                    case "/":
                        if (secondValue == 0)
                            txtManHinh.Text = "Error";
                        else
                            txtManHinh.Text = (value / secondValue).ToString();
                        break;
                }

                operationPressed = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";
            value = 0;
            operation = "";
        }
    }
}
