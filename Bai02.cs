using System;
using System.Drawing;
using System.Windows.Forms;
namespace BTH3_BT2
{
    public partial class Bai02 : Form
    {
        private Random random = new Random();
        public Bai02()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Bai02_Paint);
            this.Width = 500;
            this.Height = 300;
            this.MouseClick += (s, e) => this.Invalidate();
        }
        // Hàm thực hiện mỗi khi sự kiện Paint xảy ra sẽ vẽ lại chuỗi “Paint Event” tại một vị trí x, y ngẫu nhiên trên Form
        private void Bai02_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = random.Next(0, this.ClientSize.Width - 100);
            int y = random.Next(0, this.ClientSize.Height - 50);

            Font font = new Font("Arial", 14, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.FromArgb(
                random.Next(256), random.Next(256), random.Next(256)
            ));
            g.DrawString("Paint Event", font, brush, x, y);

            font.Dispose();
            brush.Dispose();
        }
    }
}
