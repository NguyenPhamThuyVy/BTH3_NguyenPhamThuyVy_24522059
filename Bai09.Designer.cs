namespace BTH3_BT9
{
    partial class Bai09
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
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnLuu = new Button();
            btnXoaMon = new Button();
            btnThemMon = new Button();
            lstMonHocDaChon = new ListBox();
            lstDanhSachMonHoc = new ListBox();
            label1 = new Label();
            cbNu = new CheckBox();
            cbNam = new CheckBox();
            lblGT = new Label();
            cmbCN = new ComboBox();
            lblCN = new Label();
            txtHT = new TextBox();
            lblHT = new Label();
            txtMSV = new TextBox();
            lblMSV = new Label();
            lvDanhSachSV = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoaMon);
            groupBox1.Controls.Add(btnThemMon);
            groupBox1.Controls.Add(lstMonHocDaChon);
            groupBox1.Controls.Add(lstDanhSachMonHoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbNu);
            groupBox1.Controls.Add(cbNam);
            groupBox1.Controls.Add(lblGT);
            groupBox1.Controls.Add(cmbCN);
            groupBox1.Controls.Add(lblCN);
            groupBox1.Controls.Add(txtHT);
            groupBox1.Controls.Add(lblHT);
            groupBox1.Controls.Add(txtMSV);
            groupBox1.Controls.Add(lblMSV);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.AppWorkspace;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Location = new Point(452, 337);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa Chọn";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.AppWorkspace;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Location = new Point(292, 337);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaMon
            // 
            btnXoaMon.BackColor = SystemColors.AppWorkspace;
            btnXoaMon.Cursor = Cursors.Hand;
            btnXoaMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaMon.Location = new Point(428, 275);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(56, 47);
            btnXoaMon.TabIndex = 13;
            btnXoaMon.Text = "<";
            btnXoaMon.UseVisualStyleBackColor = false;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = SystemColors.AppWorkspace;
            btnThemMon.Cursor = Cursors.Hand;
            btnThemMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemMon.Location = new Point(428, 218);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(56, 47);
            btnThemMon.TabIndex = 12;
            btnThemMon.Text = ">";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // lstMonHocDaChon
            // 
            lstMonHocDaChon.FormattingEnabled = true;
            lstMonHocDaChon.Location = new Point(490, 218);
            lstMonHocDaChon.Name = "lstMonHocDaChon";
            lstMonHocDaChon.SelectionMode = SelectionMode.MultiExtended;
            lstMonHocDaChon.Size = new Size(267, 104);
            lstMonHocDaChon.TabIndex = 11;
            // 
            // lstDanhSachMonHoc
            // 
            lstDanhSachMonHoc.FormattingEnabled = true;
            lstDanhSachMonHoc.Location = new Point(155, 218);
            lstDanhSachMonHoc.Name = "lstDanhSachMonHoc";
            lstDanhSachMonHoc.SelectionMode = SelectionMode.MultiExtended;
            lstDanhSachMonHoc.Size = new Size(267, 104);
            lstDanhSachMonHoc.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(155, 188);
            label1.Name = "label1";
            label1.Size = new Size(207, 34);
            label1.TabIndex = 9;
            label1.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // cbNu
            // 
            cbNu.AutoSize = true;
            cbNu.Location = new Point(388, 154);
            cbNu.Name = "cbNu";
            cbNu.Size = new Size(51, 24);
            cbNu.TabIndex = 8;
            cbNu.Text = "Nữ";
            cbNu.UseVisualStyleBackColor = true;
            cbNu.CheckedChanged += cbNu_CheckedChanged;
            // 
            // cbNam
            // 
            cbNam.AutoSize = true;
            cbNam.Location = new Point(292, 153);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(63, 24);
            cbNam.TabIndex = 7;
            cbNam.Text = "Nam";
            cbNam.UseVisualStyleBackColor = true;
            cbNam.CheckedChanged += cbNam_CheckedChanged;
            // 
            // lblGT
            // 
            lblGT.Location = new Point(155, 154);
            lblGT.Name = "lblGT";
            lblGT.Size = new Size(117, 34);
            lblGT.TabIndex = 6;
            lblGT.Text = "Giới Tính";
            // 
            // cmbCN
            // 
            cmbCN.FormattingEnabled = true;
            cmbCN.Location = new Point(292, 107);
            cmbCN.Name = "cmbCN";
            cmbCN.Size = new Size(341, 28);
            cmbCN.TabIndex = 5;
            // 
            // lblCN
            // 
            lblCN.Location = new Point(155, 110);
            lblCN.Name = "lblCN";
            lblCN.Size = new Size(117, 34);
            lblCN.TabIndex = 4;
            lblCN.Text = "Chuyên Ngành";
            // 
            // txtHT
            // 
            txtHT.Location = new Point(292, 63);
            txtHT.Name = "txtHT";
            txtHT.Size = new Size(341, 27);
            txtHT.TabIndex = 3;
            // 
            // lblHT
            // 
            lblHT.Location = new Point(155, 66);
            lblHT.Name = "lblHT";
            lblHT.Size = new Size(117, 34);
            lblHT.TabIndex = 2;
            lblHT.Text = "Họ Tên";
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(292, 26);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(176, 27);
            txtMSV.TabIndex = 1;
            // 
            // lblMSV
            // 
            lblMSV.Location = new Point(155, 32);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(117, 34);
            lblMSV.TabIndex = 0;
            lblMSV.Text = "Mã Sinh Viên";
            // 
            // lvDanhSachSV
            // 
            lvDanhSachSV.FullRowSelect = true;
            lvDanhSachSV.GridLines = true;
            lvDanhSachSV.Location = new Point(27, 397);
            lvDanhSachSV.Name = "lvDanhSachSV";
            lvDanhSachSV.Size = new Size(772, 237);
            lvDanhSachSV.TabIndex = 16;
            lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            lvDanhSachSV.View = View.Details;
            // 
            // Bai09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 646);
            Controls.Add(lvDanhSachSV);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Bai09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập liệu sinh viên";
            Load += Bai09_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbCN;
        private Label lblCN;
        private TextBox txtHT;
        private Label lblHT;
        private TextBox txtMSV;
        private Label lblMSV;
        private ListBox lstMonHocDaChon;
        private ListBox lstDanhSachMonHoc;
        private Label label1;
        private CheckBox cbNu;
        private CheckBox cbNam;
        private Label lblGT;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnXoaMon;
        private Button btnThemMon;
        private ListView lvDanhSachSV;
    }
}
