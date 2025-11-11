using System;
using System.Windows.Forms;
using System.Globalization;
namespace BTH3_BT6
{
    public partial class Bai06 : Form
    {
        // Khai báo các biến toàn cục
        double result = 0; // Lưu tạm giá trị số đầu tiên khi thực hiện phép tính
        string operation = ""; // Lưu kí hiệu phép toán đang chọn
        bool isOperationPerformed = false; // Dùng để xóa TextBox khi nhập số mới
        double memory = 0; // Bộ nhớ của máy (cho các nút MS, MR, M+, MC)
        string lastOperation = ""; // Lưu phép toán cuối (+, -, *, /)
        double lastNumber = 0;     // Lưu số cuối
        public Bai06()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Bai06_Load);
        }
        // Sự kiện Load
        private void Bai06_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        // Xử lý sự kiện khi nhấn các nút số
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0" || isOperationPerformed)
            {
                isOperationPerformed = false;
                if (btn.Text == ".")
                {
                    txtDisplay.Text = "0.";
                }
                else
                {
                    txtDisplay.Text = btn.Text;
                }
            }
            else
            {
                if (btn.Text != ".")
                {
                    txtDisplay.Text += btn.Text;
                }
                else if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += btn.Text;
                }
            }
        }
        // Xử lý sự kiện khi nhấn các nút phép toán
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double currentDisplayNum = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            // Xử lý khi nhấn 2 phép toán liên tục 
            // Nếu operation có, nghĩa là người dùng chưa nhấn =
            if (operation != "")
            {
                // Thực hiện phép tính đang chờ
                switch (operation)
                {
                    case "+": txtDisplay.Text = (result + currentDisplayNum).ToString(CultureInfo.InvariantCulture); break;
                    case "-": txtDisplay.Text = (result - currentDisplayNum).ToString(CultureInfo.InvariantCulture); break;
                    case "*": txtDisplay.Text = (result * currentDisplayNum).ToString(CultureInfo.InvariantCulture); break;
                    case "/":
                        if (currentDisplayNum == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtDisplay.Text = (result / currentDisplayNum).ToString(CultureInfo.InvariantCulture);
                        }
                        break;
                }
                // Hiển thị kết quả trung gian
                txtDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            // Nếu operation rỗng, nghĩa là đây là số đầu tiên (hoặc sau khi nhấn =)
            else
            {
                // Lưu số này lại
                result = currentDisplayNum;
            }
            // Đặt phép toán mới và cờ để xóa màn hình
            operation = btn.Text;
            isOperationPerformed = true;
            // Đặt lại bộ nhớ "nhấn =" vì phép toán mới đã bắt đầu
            lastOperation = "";
            lastNumber = 0;
        }
        // Xử lý sự kiện nút =
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double currentDisplayNum = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            if (operation != "") // TH Bấm = lần đầu 
            {
                // Lưu lại phép toán và con số này để lặp lại
                lastNumber = currentDisplayNum; 
                lastOperation = operation;  
                switch (operation)
                {
                    case "+": txtDisplay.Text = (result + lastNumber).ToString(CultureInfo.InvariantCulture); break;
                    case "-": txtDisplay.Text = (result - lastNumber).ToString(CultureInfo.InvariantCulture); break;
                    case "*": txtDisplay.Text = (result * lastNumber).ToString(CultureInfo.InvariantCulture); break;
                    case "/":
                        if (currentDisplayNum == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtDisplay.Text = (result / lastNumber).ToString(CultureInfo.InvariantCulture);
                        }
                        break;
                    default: break;
                }
                result = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
                operation = ""; // Xóa phép toán hiện tại
                isOperationPerformed = true;
            }
            else if (lastOperation != "") // TH Bấm = liên tục
            {
                // Dùng phép toán và con số đã lưu (lastOperation, lastNumber) để tính với KQ hiện tại 
                switch (lastOperation)
                {
                    case "+": txtDisplay.Text = (result + lastNumber).ToString(CultureInfo.InvariantCulture); break;
                    case "-": txtDisplay.Text = (result - lastNumber).ToString(CultureInfo.InvariantCulture); break;
                    case "*": txtDisplay.Text = (result * lastNumber).ToString(CultureInfo.InvariantCulture); break;
                    case "/":
                        if (lastNumber == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtDisplay.Text = (result / currentDisplayNum).ToString(CultureInfo.InvariantCulture);
                        }
                        break;
                    default: break;
                }
                result = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture); 
                isOperationPerformed = true;
            }
        }
        // Xử lý sự kiện các nút Clear
        // (1) C
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
            lastOperation = "";
            lastNumber = 0;
        }
        // (2) CE
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        // (3) Backspace
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }
        // Xử lý sự kiện nút đổi dấu
        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text = (double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture) * -1).ToString(CultureInfo.InvariantCulture);
            }
        }
        // Xử lý sự kiện nút phần trăm
        private void btnPro_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture) / 100).ToString(CultureInfo.InvariantCulture);
        }
        // Xử lý sự kiện nút căn bậc 2
        private void btnS_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            if (num < 0)
            {
                MessageBox.Show("Không thể căn bậc 2 số âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtDisplay.Text = Math.Sqrt(num).ToString(CultureInfo.InvariantCulture);
            }
        }
        // Xử lý sự kiện nút 1/x
        private void btnX_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
            if (num == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtDisplay.Text = (1 / num).ToString(CultureInfo.InvariantCulture);
            }
        }
        // Xử lý sự kiện các nút liên quan đến bộ nhớ 
        // (1) MS - lưu số hiện tại vào bộ nhớ
        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
        }
        // (2) MC - xóa bộ nhớ
        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }
        // (3) MR - gọi lại giá trị từ bộ nhớ
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString(CultureInfo.InvariantCulture);
            isOperationPerformed = true;
        }
        // (4) M+ - Cộng thêm giá trị đang lưu trong bộ nhớ
        private void btnMp_Click(object sender, EventArgs e)
        {
            memory += double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
        }
    }
}
