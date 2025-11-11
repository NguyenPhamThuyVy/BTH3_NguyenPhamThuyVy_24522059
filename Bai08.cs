using System;
using System.Globalization;
using System.Linq; 
using System.Windows.Forms;
namespace BTH3_BT8
{
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
            this.Load += Bai08_Load;
        }
        private void Bai08_Load(object sender, EventArgs e)
        {
            lvDanhSach.View = View.Details;
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lvDanhSach.Columns.Add("Mã tài khoản", 120, HorizontalAlignment.Left);
            lvDanhSach.Columns.Add("Tên khách hàng", 200, HorizontalAlignment.Left);
            lvDanhSach.Columns.Add("Địa chỉ", 250, HorizontalAlignment.Left);
            lvDanhSach.Columns.Add("Số tiền", 150, HorizontalAlignment.Right);
            CapNhatTongTien();
        }
        // Xử lý sự kiện Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý sự kiện Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string STKCanXoa = txtSTK.Text;

            if (string.IsNullOrWhiteSpace(STKCanXoa))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra nếu STK có tồn tại
            ListViewItem ItemCanXoa = TimTaiKhoan(STKCanXoa);
            if (ItemCanXoa != null)
            {
                DialogResult rs = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{STKCanXoa}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    lvDanhSach.Items.Remove(ItemCanXoa);
                    CapNhatSTT();
                    CapNhatTongTien();
                    XoaTrangTextBox();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xử lý sự kiện khi chọn 1 dòng trong ListView
        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem ItemChon = lvDanhSach.SelectedItems[0];
                // Hiển thị ngược lại thông tin lên các ô TextBox
                txtSTK.Text = ItemChon.SubItems[1].Text;
                txtTen.Text = ItemChon.SubItems[2].Text;
                txtDC.Text = ItemChon.SubItems[3].Text;
                // Loại bỏ định dạng dấu phẩy
                string SoTienFormatted = ItemChon.SubItems[4].Text;
                decimal SoTien = decimal.Parse(SoTienFormatted, NumberStyles.Any);
                txtTien.Text = SoTien.ToString();
            }
        }
        // Xử lý sự kiện nút Thêm/Cập nhật
        private void btnThemCN_Click(object sender, EventArgs e)
        {
            // Kiểm tra các thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtSTK.Text) || string.IsNullOrWhiteSpace(txtTen.Text) 
                || string.IsNullOrWhiteSpace(txtDC.Text) || string.IsNullOrWhiteSpace(txtTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra nhập STK
            if (!txtSTK.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số tài khoản chỉ nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTK.Focus();
                return;
            }
            // Kiểm tra nhập Tên khách hàng
            if (!txtTen.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ cái và khoảng trắng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
            // Kiểm tra nhập số tiền
            if (!decimal.TryParse(txtTien.Text,out decimal SoTien))
            {
                MessageBox.Show("Số tiền không hợp lệ! Vui lòng chỉ nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTien.Focus();
                return;
            }
            // Tìm kiếm số tài khoản
            ListViewItem TimThay = TimTaiKhoan(txtSTK.Text);
            if (TimThay == null)
            {
                // Thêm mới nếu chưa có dữ liệu
                ListViewItem listViewItem = new ListViewItem("");
                listViewItem.SubItems.Add(txtSTK.Text);
                listViewItem.SubItems.Add(txtTen.Text);
                listViewItem.SubItems.Add(txtDC.Text);
                listViewItem.SubItems.Add(SoTien.ToString());
                lvDanhSach.Items.Add(listViewItem);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật nếu đã tồn tại dữ liệu
                TimThay.SubItems[2].Text = txtTen.Text;
                TimThay.SubItems[3].Text = txtDC.Text;
                TimThay.SubItems[4].Text = SoTien.ToString();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CapNhatSTT();
            CapNhatTongTien();
            XoaTrangTextBox();
        }
        // Hàm tìm kiếm một tài khoản trong ListView theo STK
        private ListViewItem TimTaiKhoan(string STK)
        {
            foreach (ListViewItem item in lvDanhSach.Items)
            {
                // SubItems[1] là cột "Mã tài khoản"
                if (item.SubItems[1].Text == STK)
                {
                    return item;
                }
            }
            return null;
        }
        // Hàm cập nhật tổng tiền
        private void CapNhatTongTien()
        {
            decimal Tong = 0;
            foreach (ListViewItem item in lvDanhSach.Items)
            {
                if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal soTien))
                {
                    Tong += soTien;
                }
            }
            txtTongTien.Text = Tong.ToString();
        }
        // Hàm cập nhật lại cột STT (Số thứ tự)
        private void CapNhatSTT()
        {
            for (int i = 0; i < lvDanhSach.Items.Count; i++)
            {
                lvDanhSach.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
        // Hàm xóa trắng các ô nhập liệu
        private void XoaTrangTextBox()
        {
            txtSTK.Clear();
            txtTen.Clear();
            txtDC.Clear();
            txtTien.Clear();
            txtSTK.Focus();
        }
    }
}
