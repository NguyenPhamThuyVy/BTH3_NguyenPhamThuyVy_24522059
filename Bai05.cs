using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Globalization;

namespace BTH3_BT5
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnSub.Click += btnSub_Click;
            btnMul.Click += btnMul_Click;
            btnDiv.Click += btnDiv_Click;
        }
        // Hàm lấy dữ liệu từ 2 textbox và kiểm tra hợp lệ
        private bool GetNumber(out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;
            string sNum1 = txtNum1.Text;
            string sNum2 = txtNum2.Text;
            if (sNum1.Contains(".") || sNum2.Contains("."))
            {
                MessageBox.Show("Vui lòng dùng dấu phẩy (,) cho số thập phân, không dùng dấu chấm (.).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }
            bool input1 = double.TryParse(txtNum1.Text, out num1);
            bool input2 = double.TryParse(txtNum2.Text, out num2);
            if (!input1 || !input2)
            {
                MessageBox.Show("Vui lòng nhập hai số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // Sự kiện Click cho các nút +, -, X, /
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(GetNumber(out double num1, out double num2) )
            {
                txtAnswer.Text = (num1 + num2).ToString();
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (GetNumber(out double num1, out double num2))
            {
                txtAnswer.Text = (num1 - num2).ToString();
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            if (GetNumber(out double num1, out double num2))
            {
                txtAnswer.Text = (num1 * num2).ToString();
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (GetNumber(out double num1, out double num2))
            {
                if (num2 == 0)
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txtAnswer.Text = (num1 / num2).ToString();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
