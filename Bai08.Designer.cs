namespace BTH3_BT8
{
    partial class Bai08
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQL = new Label();
            txtSTK = new TextBox();
            txtTen = new TextBox();
            txtTien = new TextBox();
            txtDC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnThemCN = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            lvDanhSach = new ListView();
            SuspendLayout();
            // 
            // lblQL
            // 
            lblQL.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQL.ForeColor = Color.Blue;
            lblQL.Location = new Point(0, 0);
            lblQL.Name = "lblQL";
            lblQL.Size = new Size(890, 80);
            lblQL.TabIndex = 0;
            lblQL.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblQL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSTK
            // 
            txtSTK.Location = new Point(302, 83);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(413, 27);
            txtSTK.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(302, 125);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(413, 27);
            txtTen.TabIndex = 2;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(302, 211);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(413, 27);
            txtTien.TabIndex = 4;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(302, 169);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(413, 27);
            txtDC.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 85);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 5;
            label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 127);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 171);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 213);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 8;
            label4.Text = "Số tiền trong tài khoản";
            // 
            // btnThemCN
            // 
            btnThemCN.BackColor = SystemColors.AppWorkspace;
            btnThemCN.Cursor = Cursors.Hand;
            btnThemCN.Location = new Point(360, 253);
            btnThemCN.Name = "btnThemCN";
            btnThemCN.Size = new Size(126, 29);
            btnThemCN.TabIndex = 9;
            btnThemCN.Text = "Thêm/Cập nhật";
            btnThemCN.UseVisualStyleBackColor = false;
            btnThemCN.Click += btnThemCN_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.AppWorkspace;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Location = new Point(517, 253);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.AppWorkspace;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Location = new Point(630, 253);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(85, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(434, 539);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(91, 25);
            lblTongTien.TabIndex = 13;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(531, 537);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(316, 27);
            txtTongTien.TabIndex = 14;
            // 
            // lvDanhSach
            // 
            lvDanhSach.Location = new Point(12, 295);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(866, 236);
            lvDanhSach.TabIndex = 15;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            // 
            // Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 573);
            Controls.Add(lvDanhSach);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThemCN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTien);
            Controls.Add(txtDC);
            Controls.Add(txtTen);
            Controls.Add(txtSTK);
            Controls.Add(lblQL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai08";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQL;
        private TextBox txtSTK;
        private TextBox txtTen;
        private TextBox txtTien;
        private TextBox txtDC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnThemCN;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private ListView lvDanhSach;
    }
}
