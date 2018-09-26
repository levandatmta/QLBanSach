namespace QLBanHang.GUI
{
    partial class FrmBanSACH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChiTietXuat = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietBan = new System.Windows.Forms.DataGridView();
            this.IDChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SACHChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaChiTietBan = new System.Windows.Forms.Button();
            this.btnSuaChiTietBan = new System.Windows.Forms.Button();
            this.btnThemChiTietBan = new System.Windows.Forms.Button();
            this.groupThongTinChiTietBan = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSACH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHoaDonBan = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.IDPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDonBan = new System.Windows.Forms.Button();
            this.btnSuaHoaDonBan = new System.Windows.Forms.Button();
            this.btnThemHoaDonBan = new System.Windows.Forms.Button();
            this.groupThongTinHoaDonBan = new System.Windows.Forms.GroupBox();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panelChiTietXuat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupThongTinChiTietBan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHoaDonBan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupThongTinHoaDonBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChiTietXuat
            // 
            this.panelChiTietXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelChiTietXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChiTietXuat.Controls.Add(this.groupBox1);
            this.panelChiTietXuat.Controls.Add(this.panel3);
            this.panelChiTietXuat.Controls.Add(this.groupThongTinChiTietBan);
            this.panelChiTietXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChiTietXuat.Location = new System.Drawing.Point(542, 0);
            this.panelChiTietXuat.Name = "panelChiTietXuat";
            this.panelChiTietXuat.Size = new System.Drawing.Size(592, 697);
            this.panelChiTietXuat.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dgvChiTietBan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 407);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết bán";
            // 
            // dgvChiTietBan
            // 
            this.dgvChiTietBan.AllowUserToResizeColumns = false;
            this.dgvChiTietBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiTietBan.ColumnHeadersHeight = 30;
            this.dgvChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChiTietNhap,
            this.STTChiTietNhap,
            this.SACHChiTietNhap,
            this.SoLuongChiTietNhap,
            this.DonGiaChiTietNhap,
            this.ThanhTienChiTietNhap});
            this.dgvChiTietBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietBan.EnableHeadersVisualStyles = false;
            this.dgvChiTietBan.GridColor = System.Drawing.Color.Black;
            this.dgvChiTietBan.Location = new System.Drawing.Point(3, 19);
            this.dgvChiTietBan.MultiSelect = false;
            this.dgvChiTietBan.Name = "dgvChiTietBan";
            this.dgvChiTietBan.ReadOnly = true;
            this.dgvChiTietBan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiTietBan.RowHeadersWidth = 25;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietBan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTietBan.RowTemplate.Height = 30;
            this.dgvChiTietBan.RowTemplate.ReadOnly = true;
            this.dgvChiTietBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBan.Size = new System.Drawing.Size(584, 385);
            this.dgvChiTietBan.TabIndex = 4;
            this.dgvChiTietBan.SelectionChanged += new System.EventHandler(this.dgvChiTietNhap_SelectionChanged);
            // 
            // IDChiTietNhap
            // 
            this.IDChiTietNhap.DataPropertyName = "ID";
            this.IDChiTietNhap.HeaderText = "ID";
            this.IDChiTietNhap.Name = "IDChiTietNhap";
            this.IDChiTietNhap.ReadOnly = true;
            this.IDChiTietNhap.Visible = false;
            // 
            // STTChiTietNhap
            // 
            this.STTChiTietNhap.DataPropertyName = "STT";
            this.STTChiTietNhap.FillWeight = 7F;
            this.STTChiTietNhap.HeaderText = "STT";
            this.STTChiTietNhap.Name = "STTChiTietNhap";
            this.STTChiTietNhap.ReadOnly = true;
            // 
            // SACHChiTietNhap
            // 
            this.SACHChiTietNhap.DataPropertyName = "SACH";
            this.SACHChiTietNhap.FillWeight = 30F;
            this.SACHChiTietNhap.HeaderText = "Mặt hàng";
            this.SACHChiTietNhap.Name = "SACHChiTietNhap";
            this.SACHChiTietNhap.ReadOnly = true;
            // 
            // SoLuongChiTietNhap
            // 
            this.SoLuongChiTietNhap.DataPropertyName = "SoLuong";
            this.SoLuongChiTietNhap.FillWeight = 15F;
            this.SoLuongChiTietNhap.HeaderText = "Số lượng";
            this.SoLuongChiTietNhap.Name = "SoLuongChiTietNhap";
            this.SoLuongChiTietNhap.ReadOnly = true;
            // 
            // DonGiaChiTietNhap
            // 
            this.DonGiaChiTietNhap.DataPropertyName = "DonGia";
            this.DonGiaChiTietNhap.FillWeight = 15F;
            this.DonGiaChiTietNhap.HeaderText = "Đơn giá";
            this.DonGiaChiTietNhap.Name = "DonGiaChiTietNhap";
            this.DonGiaChiTietNhap.ReadOnly = true;
            // 
            // ThanhTienChiTietNhap
            // 
            this.ThanhTienChiTietNhap.DataPropertyName = "ThanhTien";
            this.ThanhTienChiTietNhap.FillWeight = 15F;
            this.ThanhTienChiTietNhap.HeaderText = "Thành tiền";
            this.ThanhTienChiTietNhap.Name = "ThanhTienChiTietNhap";
            this.ThanhTienChiTietNhap.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numSoLuong);
            this.panel3.Controls.Add(this.btnTraSach);
            this.panel3.Controls.Add(this.btnXoaChiTietBan);
            this.panel3.Controls.Add(this.btnSuaChiTietBan);
            this.panel3.Controls.Add(this.btnThemChiTietBan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 48);
            this.panel3.TabIndex = 4;
            // 
            // btnXoaChiTietBan
            // 
            this.btnXoaChiTietBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaChiTietBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChiTietBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiTietBan.ForeColor = System.Drawing.Color.Black;
            this.btnXoaChiTietBan.Location = new System.Drawing.Point(221, 5);
            this.btnXoaChiTietBan.Name = "btnXoaChiTietBan";
            this.btnXoaChiTietBan.Size = new System.Drawing.Size(103, 35);
            this.btnXoaChiTietBan.TabIndex = 12;
            this.btnXoaChiTietBan.Text = "Xóa";
            this.btnXoaChiTietBan.UseVisualStyleBackColor = false;
            this.btnXoaChiTietBan.Click += new System.EventHandler(this.btnXoaChiTietBan_Click);
            // 
            // btnSuaChiTietBan
            // 
            this.btnSuaChiTietBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaChiTietBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaChiTietBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTietBan.ForeColor = System.Drawing.Color.Black;
            this.btnSuaChiTietBan.Location = new System.Drawing.Point(112, 5);
            this.btnSuaChiTietBan.Name = "btnSuaChiTietBan";
            this.btnSuaChiTietBan.Size = new System.Drawing.Size(103, 35);
            this.btnSuaChiTietBan.TabIndex = 11;
            this.btnSuaChiTietBan.Text = "Sửa";
            this.btnSuaChiTietBan.UseVisualStyleBackColor = false;
            this.btnSuaChiTietBan.Click += new System.EventHandler(this.btnSuaChiTietBan_Click);
            // 
            // btnThemChiTietBan
            // 
            this.btnThemChiTietBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemChiTietBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemChiTietBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTietBan.ForeColor = System.Drawing.Color.Black;
            this.btnThemChiTietBan.Location = new System.Drawing.Point(3, 5);
            this.btnThemChiTietBan.Name = "btnThemChiTietBan";
            this.btnThemChiTietBan.Size = new System.Drawing.Size(103, 35);
            this.btnThemChiTietBan.TabIndex = 10;
            this.btnThemChiTietBan.Text = "Thêm";
            this.btnThemChiTietBan.UseVisualStyleBackColor = false;
            this.btnThemChiTietBan.Click += new System.EventHandler(this.btnThemChiTietBan_Click);
            // 
            // groupThongTinChiTietBan
            // 
            this.groupThongTinChiTietBan.BackColor = System.Drawing.Color.White;
            this.groupThongTinChiTietBan.Controls.Add(this.txtDonGia);
            this.groupThongTinChiTietBan.Controls.Add(this.txtThanhTien);
            this.groupThongTinChiTietBan.Controls.Add(this.txtSoLuong);
            this.groupThongTinChiTietBan.Controls.Add(this.txtTacGia);
            this.groupThongTinChiTietBan.Controls.Add(this.label7);
            this.groupThongTinChiTietBan.Controls.Add(this.cbxSACH);
            this.groupThongTinChiTietBan.Controls.Add(this.label6);
            this.groupThongTinChiTietBan.Controls.Add(this.label5);
            this.groupThongTinChiTietBan.Controls.Add(this.label4);
            this.groupThongTinChiTietBan.Controls.Add(this.label1);
            this.groupThongTinChiTietBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTinChiTietBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinChiTietBan.Location = new System.Drawing.Point(0, 0);
            this.groupThongTinChiTietBan.Name = "groupThongTinChiTietBan";
            this.groupThongTinChiTietBan.Size = new System.Drawing.Size(590, 240);
            this.groupThongTinChiTietBan.TabIndex = 1;
            this.groupThongTinChiTietBan.TabStop = false;
            this.groupThongTinChiTietBan.Text = "Thông tin chi tiết bán";
            // 
            // txtDonGia
            // 
            this.txtDonGia.AutoSize = true;
            this.txtDonGia.Location = new System.Drawing.Point(239, 157);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(43, 16);
            this.txtDonGia.TabIndex = 15;
            this.txtDonGia.Text = "50000";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(242, 195);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(190, 23);
            this.txtThanhTien.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(242, 113);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(190, 23);
            this.txtSoLuong.TabIndex = 12;
            // 
            // txtTacGia
            // 
            this.txtTacGia.AutoSize = true;
            this.txtTacGia.Location = new System.Drawing.Point(239, 75);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(40, 16);
            this.txtTacGia.TabIndex = 11;
            this.txtTacGia.Text = "Chiếc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thành tiền :";
            // 
            // cbxSACH
            // 
            this.cbxSACH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxSACH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSACH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSACH.FormattingEnabled = true;
            this.cbxSACH.Location = new System.Drawing.Point(242, 30);
            this.cbxSACH.Name = "cbxSACH";
            this.cbxSACH.Size = new System.Drawing.Size(190, 23);
            this.cbxSACH.TabIndex = 9;
            this.cbxSACH.SelectedIndexChanged += new System.EventHandler(this.cbxSACH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tác giả : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đầu sách :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelHoaDonBan);
            this.panel1.Controls.Add(this.panelChiTietXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 699);
            this.panel1.TabIndex = 1;
            // 
            // panelHoaDonBan
            // 
            this.panelHoaDonBan.Controls.Add(this.groupBox3);
            this.panelHoaDonBan.Controls.Add(this.panel5);
            this.panelHoaDonBan.Controls.Add(this.groupThongTinHoaDonBan);
            this.panelHoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.panelHoaDonBan.Name = "panelHoaDonBan";
            this.panelHoaDonBan.Size = new System.Drawing.Size(542, 697);
            this.panelHoaDonBan.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.dgvHoaDonBan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 408);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.AllowUserToResizeColumns = false;
            this.dgvHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHoaDonBan.ColumnHeadersHeight = 30;
            this.dgvHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhieuNhap,
            this.STTPhieuNhap,
            this.NgayPhieuNhap,
            this.NhanVien,
            this.DiaDiem,
            this.TongTien});
            this.dgvHoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonBan.EnableHeadersVisualStyles = false;
            this.dgvHoaDonBan.GridColor = System.Drawing.Color.Black;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(3, 19);
            this.dgvHoaDonBan.MultiSelect = false;
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.ReadOnly = true;
            this.dgvHoaDonBan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHoaDonBan.RowHeadersWidth = 25;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDonBan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDonBan.RowTemplate.Height = 30;
            this.dgvHoaDonBan.RowTemplate.ReadOnly = true;
            this.dgvHoaDonBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(536, 386);
            this.dgvHoaDonBan.TabIndex = 3;
            this.dgvHoaDonBan.SelectionChanged += new System.EventHandler(this.dgvHOADONBAN_SelectionChanged);
            // 
            // IDPhieuNhap
            // 
            this.IDPhieuNhap.DataPropertyName = "ID";
            this.IDPhieuNhap.HeaderText = "IDPhieuNhap";
            this.IDPhieuNhap.Name = "IDPhieuNhap";
            this.IDPhieuNhap.ReadOnly = true;
            this.IDPhieuNhap.Visible = false;
            // 
            // STTPhieuNhap
            // 
            this.STTPhieuNhap.DataPropertyName = "STT";
            this.STTPhieuNhap.FillWeight = 7F;
            this.STTPhieuNhap.HeaderText = "TT";
            this.STTPhieuNhap.Name = "STTPhieuNhap";
            this.STTPhieuNhap.ReadOnly = true;
            // 
            // NgayPhieuNhap
            // 
            this.NgayPhieuNhap.DataPropertyName = "Ngay";
            this.NgayPhieuNhap.FillWeight = 15F;
            this.NgayPhieuNhap.HeaderText = "Ngày";
            this.NgayPhieuNhap.Name = "NgayPhieuNhap";
            this.NgayPhieuNhap.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "NhanVien";
            this.NhanVien.FillWeight = 30F;
            this.NhanVien.HeaderText = "Nhân viên";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ReadOnly = true;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.FillWeight = 40F;
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            this.DiaDiem.Visible = false;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.FillWeight = 15F;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnInHoaDon);
            this.panel5.Controls.Add(this.btnXoaHoaDonBan);
            this.panel5.Controls.Add(this.btnSuaHoaDonBan);
            this.panel5.Controls.Add(this.btnThemHoaDonBan);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(542, 48);
            this.panel5.TabIndex = 5;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.White;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Location = new System.Drawing.Point(330, 5);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(103, 35);
            this.btnInHoaDon.TabIndex = 13;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoaHoaDonBan
            // 
            this.btnXoaHoaDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHoaDonBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnXoaHoaDonBan.Location = new System.Drawing.Point(221, 5);
            this.btnXoaHoaDonBan.Name = "btnXoaHoaDonBan";
            this.btnXoaHoaDonBan.Size = new System.Drawing.Size(103, 35);
            this.btnXoaHoaDonBan.TabIndex = 12;
            this.btnXoaHoaDonBan.Text = "Xóa";
            this.btnXoaHoaDonBan.UseVisualStyleBackColor = false;
            this.btnXoaHoaDonBan.Click += new System.EventHandler(this.btnXoaHOADONBAN_Click);
            // 
            // btnSuaHoaDonBan
            // 
            this.btnSuaHoaDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHoaDonBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnSuaHoaDonBan.Location = new System.Drawing.Point(112, 5);
            this.btnSuaHoaDonBan.Name = "btnSuaHoaDonBan";
            this.btnSuaHoaDonBan.Size = new System.Drawing.Size(103, 35);
            this.btnSuaHoaDonBan.TabIndex = 11;
            this.btnSuaHoaDonBan.Text = "Sửa";
            this.btnSuaHoaDonBan.UseVisualStyleBackColor = false;
            this.btnSuaHoaDonBan.Click += new System.EventHandler(this.btnSuaHOADONBAN_Click);
            // 
            // btnThemHoaDonBan
            // 
            this.btnThemHoaDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHoaDonBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnThemHoaDonBan.Location = new System.Drawing.Point(3, 5);
            this.btnThemHoaDonBan.Name = "btnThemHoaDonBan";
            this.btnThemHoaDonBan.Size = new System.Drawing.Size(103, 35);
            this.btnThemHoaDonBan.TabIndex = 10;
            this.btnThemHoaDonBan.Text = "Thêm";
            this.btnThemHoaDonBan.UseVisualStyleBackColor = false;
            this.btnThemHoaDonBan.Click += new System.EventHandler(this.btnThemHOADONBAN_Click);
            // 
            // groupThongTinHoaDonBan
            // 
            this.groupThongTinHoaDonBan.BackColor = System.Drawing.Color.White;
            this.groupThongTinHoaDonBan.Controls.Add(this.cbxNhanVien);
            this.groupThongTinHoaDonBan.Controls.Add(this.label9);
            this.groupThongTinHoaDonBan.Controls.Add(this.dateNgayNhap);
            this.groupThongTinHoaDonBan.Controls.Add(this.label2);
            this.groupThongTinHoaDonBan.Controls.Add(this.txtTongTien);
            this.groupThongTinHoaDonBan.Controls.Add(this.label3);
            this.groupThongTinHoaDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTinHoaDonBan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.groupThongTinHoaDonBan.Name = "groupThongTinHoaDonBan";
            this.groupThongTinHoaDonBan.Size = new System.Drawing.Size(542, 241);
            this.groupThongTinHoaDonBan.TabIndex = 2;
            this.groupThongTinHoaDonBan.TabStop = false;
            this.groupThongTinHoaDonBan.Text = "Thông tin hóa đơn bán";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanVien.Enabled = false;
            this.cbxNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(184, 32);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(190, 23);
            this.cbxNhanVien.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nhân viên :";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayNhap.Location = new System.Drawing.Point(184, 70);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(102, 23);
            this.dateNgayNhap.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng tiền : ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(184, 114);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 23);
            this.txtTongTien.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày : ";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.White;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.ForeColor = System.Drawing.Color.Black;
            this.btnTraSach.Location = new System.Drawing.Point(418, 5);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(103, 35);
            this.btnTraSach.TabIndex = 13;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(527, 13);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(59, 22);
            this.numSoLuong.TabIndex = 14;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmBanSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 699);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanSACH";
            this.Text = "FrmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            this.panelChiTietXuat.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupThongTinChiTietBan.ResumeLayout(false);
            this.groupThongTinChiTietBan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelHoaDonBan.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupThongTinHoaDonBan.ResumeLayout(false);
            this.groupThongTinHoaDonBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelChiTietXuat;
        private System.Windows.Forms.GroupBox groupThongTinChiTietBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaChiTietBan;
        private System.Windows.Forms.Button btnSuaChiTietBan;
        private System.Windows.Forms.Button btnThemChiTietBan;
        private System.Windows.Forms.Panel panelHoaDonBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoaHoaDonBan;
        private System.Windows.Forms.Button btnSuaHoaDonBan;
        private System.Windows.Forms.Button btnThemHoaDonBan;
        private System.Windows.Forms.GroupBox groupThongTinHoaDonBan;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSACH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTacGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridView dgvChiTietBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SACHChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienChiTietNhap;
        private System.Windows.Forms.Label txtDonGia;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.NumericUpDown numSoLuong;
    }
}