using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BTH3_BT9
{
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }
        private void Bai09_Load(object sender, EventArgs e)
        {
            lvDanhSachSV.Columns.Add("MSSV", 150, HorizontalAlignment.Center);
            lvDanhSachSV.Columns.Add("Họ Tên", 200, HorizontalAlignment.Center);
            lvDanhSachSV.Columns.Add("Chuyên Ngành", 200, HorizontalAlignment.Center);
            lvDanhSachSV.Columns.Add("Giới Tính", 80, HorizontalAlignment.Center);
            lvDanhSachSV.Columns.Add("Số Môn", -2, HorizontalAlignment.Center);

            cmbCN.Items.Add("Hệ Thống Thông Tin");
            cmbCN.Items.Add("Kỹ Thuật Phần Mềm");
            cmbCN.Items.Add("Khoa Học Máy Tính");
            cmbCN.Items.Add("Khoa Học Dữ Liệu");
            cmbCN.Items.Add("An Toàn Thông Tin");
            cmbCN.Items.Add("Kỹ Thuật Máy Tính");
            cmbCN.Items.Add("Trí Tuệ Nhân Tạo");
            cmbCN.Items.Add("Thiết Kế Vi Mạch");
            cmbCN.Items.Add("Thương Mại Điện Tử");
            cmbCN.Items.Add("Công Nghệ Thông Tin");
            cmbCN.Items.Add("Truyền Thông Đa Phương Tiện");
            cmbCN.Items.Add("Mạng Máy Tính & Truyền Thông Dữ Liệu");
            cmbCN.SelectedIndex = 0;

            lstDanhSachMonHoc.Items.Add("Cơ Sở Dữ Liệu");
            lstDanhSachMonHoc.Items.Add("Cơ Sở DL NC");
            lstDanhSachMonHoc.Items.Add("PTTK Hệ Thống thông tin");
        }
        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked)
            {
                cbNu.Checked = false;
            }
        }
        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked)
            {
                cbNam.Checked = false;
            }
        }
        // Xử lý sự kiện cho nút Thêm Môn (>)
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<object>();
            foreach (var item in lstDanhSachMonHoc.SelectedItems)
            {
                selectedItems.Add(item);
            }
            foreach (var item in selectedItems)
            {
                lstMonHocDaChon.Items.Add(item);
                lstDanhSachMonHoc.Items.Remove(item);
            }
        }
        // Xử lý sự kiện cho nút Xóa Môn (<)
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<object>();
            foreach (var item in lstMonHocDaChon.SelectedItems)
            {
                selectedItems.Add(item);
            }
            foreach (var item in selectedItems)
            {
                lstDanhSachMonHoc.Items.Add(item);
                lstMonHocDaChon.Items.Remove(item);
            }
        }
        // Xử lý sự kiện cho nút Lưu Thông Tin
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txtMSV.Text) || string.IsNullOrWhiteSpace(txtHT.Text)
                || !cbNam.Checked && !cbNu.Checked || lstMonHocDaChon.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHT.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHT.Focus();
                return;
            }
            if (!txtHT.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ cái và khoảng trắng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHT.Focus();
                return;
            }
            // Lấy thông tin
            string mssv = txtMSV.Text;
            string hoTen = txtHT.Text;
            string chuyenNganh = cmbCN.Text;
            string gioiTinh = cbNam.Checked ? "Nam" : "Nữ";
            string soMon = lstMonHocDaChon.Items.Count.ToString();
            // Tạo 1 dòng trong ListView
            ListViewItem listViewItem = new ListViewItem(mssv);
            listViewItem.SubItems.Add(hoTen);
            listViewItem.SubItems.Add(chuyenNganh);
            listViewItem.SubItems.Add(gioiTinh);
            listViewItem.SubItems.Add(soMon);
            // Thêm dòng vào ListView
            lvDanhSachSV.Items.Add(listViewItem);
            // Reset form
            btnXoa.PerformClick();
        }
        // Xử lý sự kiện cho nút Xóa Chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMSV.Clear();
            txtHT.Clear();
            cmbCN.SelectedIndex = 0;
            cbNam.Checked = false;
            cbNu.Checked = false;
            foreach (var item in lstMonHocDaChon.Items)
            {
                lstDanhSachMonHoc.Items.Add(item);
            }
            lstMonHocDaChon.Items.Clear();
            txtMSV.Focus();
        }
    }
}
