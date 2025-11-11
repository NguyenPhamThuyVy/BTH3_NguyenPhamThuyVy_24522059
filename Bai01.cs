using System;
using System.Windows.Forms;
using System.Diagnostics;
namespace BTH3_BT1
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
            this.Load += Bai01_Load;
            this.Shown += Bai01_Shown;
            this.GotFocus += Bai01_GotFocus;
            this.Activated += Bai01_Activated;
            this.Deactivate += Bai01_Deactivate;
            this.Click += Bai01_Click;
            this.Resize += Bai01_Resize;
            this.FormClosing += Bai01_FormClosing;
            this.FormClosed += Bai01_FormClosed;
            this.Disposed += Bai01_Disposed;
            LogEvent("1. Constructor (Form được tạo)");
        }
        private void Bai01_Load(object sender, EventArgs e)
        {
            LogEvent("2. Form_Load (Form đang tải)....");
        }
        private void Bai01_Shown(object sender, EventArgs e)
        {
            LogEvent("3. Form_Shown (Form đã hiển thị lần đầu)");
        }
        private void Bai01_GotFocus(object sender, EventArgs e)
        {
            LogEvent("4. Form_GotFocus (Form nhận focus)");
        }
        private void Bai01_Activated(object sender, EventArgs e)
        {
            LogEvent("5. Form_Activated(Form được focus)");
        }
        private void Bai01_Deactivate(object sender, EventArgs e)
        {
            LogEvent("6. Form_Deactivate(Form mất focus)");
        }
        private void Bai01_Click(object sender, EventArgs e)
        {
            LogEvent("7. Form_Click (Nhấn chuột vào form)");
        }
        private void Bai01_Resize(object sender, EventArgs e)
        {
            LogEvent("8. Form_Resize (Form thay đổi kích thước)");
        }
        private void Bai01_FormClosing(object sender, EventArgs e)
        {
            LogEvent("9. Form_Closing (Form chuẩn bị đóng)");
        }
        private void Bai01_FormClosed(object sender, EventArgs e)
        {
            LogEvent("10. Form_Closed (Form đã đóng)");
        }
        private void Bai01_Disposed(object sender, EventArgs e)
        {
            Debug.WriteLine("11. Disposed (Form đã bị hủy hoàn toàn)");
        }
        private void LogEvent(string eventName)
        {
            string logEntry = $"{DateTime.Now:HH:mm:ss.fff} - {eventName}";

            // Kiểm tra xem ListBox có tồn tại và chưa bị hủy không
            if (lstEvent != null && !lstEvent.IsDisposed)
            {
                lstEvent.Items.Add(logEntry);
                lstEvent.TopIndex = lstEvent.Items.Count - 1;
            }
        }
    }
}
