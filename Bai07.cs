using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace BTH3_BT7
{
    public partial class Bai07 : Form
    {
        // Mảng ghe
        Button[] ghe = new Button[15];
        // Danh sách các ghế đang chọn
        List<Button> DangChon = new List<Button>();
        // Giá vé theo từng hàng
        const int giaA = 5000, giaB = 6500, giaC = 8000;
        public Bai07()
        {
            InitializeComponent();
            this.Load += Bai07_Load;
        }
        private void Bai07_Load(object sender, EventArgs e)
        {
            ghe[0] = btn1; ghe[1] = btn2; ghe[2] = btn3; ghe[3] = btn4; ghe[4] = btn5;
            ghe[5] = btn6; ghe[6] = btn7; ghe[7] = btn8; ghe[8] = btn9; ghe[9] = btn10;
            ghe[10] = btn11; ghe[11] = btn12; ghe[12] = btn13; ghe[13] = btn14; ghe[14] = btn15;
            
            for (int i = 0; i < 15; i++)
            {
                if (i < 5) ghe[i].Tag = "A";
                else if (i < 10) ghe[i].Tag = "B";
                else ghe[i].Tag = "C";

                ghe[i].BackColor = Color.White;
            }
            txtDisplay.Text = "0";
        }
        // Xử lý sự kiện khi nhấn vào ghế
        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // Nếu ghế màu vàng nghĩa là đã được bán
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế {btn.Text} đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Nếu ghế màu xanh nghĩa là đang chọn
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                DangChon.Remove(btn);
            }
            // Nếu ghế là màu trắng nghĩa là chưa chọn
            else if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                DangChon.Add(btn);
            }
        }
        // Xử lý sự kiện cho nút Chọn
        private void btnChon_Click(object sender, EventArgs e)
        {
            int T1 = 0;
            foreach (Button b in DangChon)
            {
                string hang = b.Tag.ToString();
                if (hang == "A") T1 += giaA;
                else if (hang == "B") T1 += giaB;
                else T1 += giaC;

                b.BackColor = Color.Yellow;
            }
            txtDisplay.Text = T1.ToString();
            DangChon.Clear();
        }
        // Xử lý sự kiện cho nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button b in DangChon)
            {
                b.BackColor = Color.White;
            }
            txtDisplay.Text = "0";
            DangChon.Clear();
        }
        // Xử lý sự kiện cho nút Kết thúc
        private void btnKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
