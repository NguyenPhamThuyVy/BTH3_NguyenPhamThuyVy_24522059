using System;
using System.Drawing;
using System.Windows.Forms;
namespace BTH3_BT3
{
    public partial class Bai03 : Form
    {
        private Random random = new Random();
        public Bai03()
        {
            InitializeComponent();
        }
        // Hàm đổi màu nền của Form sang màu ngẫu nhiên khi nhấn nút Change Color
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = Color.FromArgb(r, g, b);
            this.BackColor = color;
        }
    }
}
