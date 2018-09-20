namespace QLBanHang.GUI
{
    partial class FrmNhapSACH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChiTietNhap = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.IDChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SACHChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienChiTietNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaChiTietNhap = new System.Windows.Forms.Button();
            this.btnSuaChiTietNhap = new System.Windows.Forms.Button();
            this.btnThemChiTietNhap = new System.Windows.Forms.Button();
            this.groupThongTinChiTietNhap = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSACH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPhieuNhap = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.IDPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoaPhieuNhap = new System.Windows.Forms.Button();
            this.btnSuaPhieuNhap = new System.Windows.Forms.Button();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.groupThongTinPhieuNhap = new System.Windows.Forms.GroupBox();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelChiTietNhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupThongTinChiTietNhap.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPhieuNhap.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupThongTinPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChiTietNhap
            // 
            this.panelChiTietNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelChiTietNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChiTietNhap.Controls.Add(this.groupBox1);
            this.panelChiTietNhap.Controls.Add(this.panel3);
            this.panelChiTietNhap.Controls.Add(this.groupThongTinChiTietNhap);
            this.panelChiTietNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChiTietNhap.Location = new System.Drawing.Point(542, 0);
            this.panelChiTietNhap.Name = "panelChiTietNhap";
            this.panelChiTietNhap.Size = new System.Drawing.Size(592, 697);
            this.panelChiTietNhap.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dgvChiTietNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 407);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết Nhập";
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.AllowUserToResizeColumns = false;
            this.dgvChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiTietNhap.ColumnHeadersHeight = 30;
            this.dgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChiTietNhap,
            this.STTChiTietNhap,
            this.SACHChiTietNhap,
            this.SoLuongChiTietNhap,
            this.DonGiaChiTietNhap,
            this.ThanhTienChiTietNhap});
            this.dgvChiTietNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNhap.EnableHeadersVisualStyles = false;
            this.dgvChiTietNhap.GridColor = System.Drawing.Color.Black;
            this.dgvChiTietNhap.Location = new System.Drawing.Point(3, 19);
            this.dgvChiTietNhap.MultiSelect = false;
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.ReadOnly = true;
            this.dgvChiTietNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiTietNhap.RowHeadersWidth = 25;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietNhap.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietNhap.RowTemplate.Height = 30;
            this.dgvChiTietNhap.RowTemplate.ReadOnly = true;
            this.dgvChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(584, 385);
            this.dgvChiTietNhap.TabIndex = 4;
            this.dgvChiTietNhap.SelectionChanged += new System.EventHandler(this.dgvChiTietNhap_SelectionChanged);
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
            this.panel3.Controls.Add(this.btnXoaChiTietNhap);
            this.panel3.Controls.Add(this.btnSuaChiTietNhap);
            this.panel3.Controls.Add(this.btnThemChiTietNhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 48);
            this.panel3.TabIndex = 4;
            // 
            // btnXoaChiTietNhap
            // 
            this.btnXoaChiTietNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaChiTietNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChiTietNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiTietNhap.ForeColor = System.Drawing.Color.Black;
            this.btnXoaChiTietNhap.Location = new System.Drawing.Point(221, 5);
            this.btnXoaChiTietNhap.Name = "btnXoaChiTietNhap";
            this.btnXoaChiTietNhap.Size = new System.Drawing.Size(103, 35);
            this.btnXoaChiTietNhap.TabIndex = 12;
            this.btnXoaChiTietNhap.Text = "Xóa";
            this.btnXoaChiTietNhap.UseVisualStyleBackColor = false;
            this.btnXoaChiTietNhap.Click += new System.EventHandler(this.btnXoaChiTietNhap_Click);
            // 
            // btnSuaChiTietNhap
            // 
            this.btnSuaChiTietNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaChiTietNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaChiTietNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTietNhap.ForeColor = System.Drawing.Color.Black;
            this.btnSuaChiTietNhap.Location = new System.Drawing.Point(112, 5);
            this.btnSuaChiTietNhap.Name = "btnSuaChiTietNhap";
            this.btnSuaChiTietNhap.Size = new System.Drawing.Size(103, 35);
            this.btnSuaChiTietNhap.TabIndex = 11;
            this.btnSuaChiTietNhap.Text = "Sửa";
            this.btnSuaChiTietNhap.UseVisualStyleBackColor = false;
            this.btnSuaChiTietNhap.Click += new System.EventHandler(this.btnSuaChiTietNhap_Click);
            // 
            // btnThemChiTietNhap
            // 
            this.btnThemChiTietNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemChiTietNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemChiTietNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTietNhap.ForeColor = System.Drawing.Color.Black;
            this.btnThemChiTietNhap.Location = new System.Drawing.Point(3, 5);
            this.btnThemChiTietNhap.Name = "btnThemChiTietNhap";
            this.btnThemChiTietNhap.Size = new System.Drawing.Size(103, 35);
            this.btnThemChiTietNhap.TabIndex = 10;
            this.btnThemChiTietNhap.Text = "Thêm";
            this.btnThemChiTietNhap.UseVisualStyleBackColor = false;
            this.btnThemChiTietNhap.Click += new System.EventHandler(this.btnThemChiTietNhap_Click);
            // 
            // groupThongTinChiTietNhap
            // 
            this.groupThongTinChiTietNhap.BackColor = System.Drawing.Color.White;
            this.groupThongTinChiTietNhap.Controls.Add(this.txtThanhTien);
            this.groupThongTinChiTietNhap.Controls.Add(this.txtDonGia);
            this.groupThongTinChiTietNhap.Controls.Add(this.txtSoLuong);
            this.groupThongTinChiTietNhap.Controls.Add(this.txtTacGia);
            this.groupThongTinChiTietNhap.Controls.Add(this.label7);
            this.groupThongTinChiTietNhap.Controls.Add(this.cbxSACH);
            this.groupThongTinChiTietNhap.Controls.Add(this.label6);
            this.groupThongTinChiTietNhap.Controls.Add(this.label5);
            this.groupThongTinChiTietNhap.Controls.Add(this.label4);
            this.groupThongTinChiTietNhap.Controls.Add(this.label1);
            this.groupThongTinChiTietNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTinChiTietNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinChiTietNhap.Location = new System.Drawing.Point(0, 0);
            this.groupThongTinChiTietNhap.Name = "groupThongTinChiTietNhap";
            this.groupThongTinChiTietNhap.Size = new System.Drawing.Size(590, 240);
            this.groupThongTinChiTietNhap.TabIndex = 1;
            this.groupThongTinChiTietNhap.TabStop = false;
            this.groupThongTinChiTietNhap.Text = "Thông tin chi tiết Nhập";
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
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(242, 154);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 23);
            this.txtDonGia.TabIndex = 13;
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
            this.panel1.Controls.Add(this.panelPhieuNhap);
            this.panel1.Controls.Add(this.panelChiTietNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 699);
            this.panel1.TabIndex = 1;
            // 
            // panelPhieuNhap
            // 
            this.panelPhieuNhap.Controls.Add(this.groupBox3);
            this.panelPhieuNhap.Controls.Add(this.panel5);
            this.panelPhieuNhap.Controls.Add(this.groupThongTinPhieuNhap);
            this.panelPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.panelPhieuNhap.Name = "panelPhieuNhap";
            this.panelPhieuNhap.Size = new System.Drawing.Size(542, 697);
            this.panelPhieuNhap.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.dgvPhieuNhap);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 408);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPhieuNhap.ColumnHeadersHeight = 30;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhieuNhap,
            this.STTPhieuNhap,
            this.NgayPhieuNhap,
            this.NhanVien,
            this.DiaDiem,
            this.TongTien});
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvPhieuNhap.GridColor = System.Drawing.Color.Black;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(3, 19);
            this.dgvPhieuNhap.MultiSelect = false;
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPhieuNhap.RowHeadersWidth = 25;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuNhap.RowTemplate.Height = 30;
            this.dgvPhieuNhap.RowTemplate.ReadOnly = true;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(536, 386);
            this.dgvPhieuNhap.TabIndex = 3;
            this.dgvPhieuNhap.SelectionChanged += new System.EventHandler(this.dgvPhieuNhap_SelectionChanged);
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
            this.panel5.Controls.Add(this.btnXoaPhieuNhap);
            this.panel5.Controls.Add(this.btnSuaPhieuNhap);
            this.panel5.Controls.Add(this.btnThemPhieuNhap);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(542, 48);
            this.panel5.TabIndex = 5;
            // 
            // btnXoaPhieuNhap
            // 
            this.btnXoaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhieuNhap.Location = new System.Drawing.Point(221, 5);
            this.btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            this.btnXoaPhieuNhap.Size = new System.Drawing.Size(103, 35);
            this.btnXoaPhieuNhap.TabIndex = 12;
            this.btnXoaPhieuNhap.Text = "Xóa";
            this.btnXoaPhieuNhap.UseVisualStyleBackColor = false;
            this.btnXoaPhieuNhap.Click += new System.EventHandler(this.btnXoaPhieuNhap_Click);
            // 
            // btnSuaPhieuNhap
            // 
            this.btnSuaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPhieuNhap.Location = new System.Drawing.Point(112, 5);
            this.btnSuaPhieuNhap.Name = "btnSuaPhieuNhap";
            this.btnSuaPhieuNhap.Size = new System.Drawing.Size(103, 35);
            this.btnSuaPhieuNhap.TabIndex = 11;
            this.btnSuaPhieuNhap.Text = "Sửa";
            this.btnSuaPhieuNhap.UseVisualStyleBackColor = false;
            this.btnSuaPhieuNhap.Click += new System.EventHandler(this.btnSuaPhieuNhap_Click);
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(3, 5);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(103, 35);
            this.btnThemPhieuNhap.TabIndex = 10;
            this.btnThemPhieuNhap.Text = "Thêm";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = false;
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // groupThongTinPhieuNhap
            // 
            this.groupThongTinPhieuNhap.BackColor = System.Drawing.Color.White;
            this.groupThongTinPhieuNhap.Controls.Add(this.cbxNhanVien);
            this.groupThongTinPhieuNhap.Controls.Add(this.label9);
            this.groupThongTinPhieuNhap.Controls.Add(this.dateNgayNhap);
            this.groupThongTinPhieuNhap.Controls.Add(this.label2);
            this.groupThongTinPhieuNhap.Controls.Add(this.txtDiaDiem);
            this.groupThongTinPhieuNhap.Controls.Add(this.txtTongTien);
            this.groupThongTinPhieuNhap.Controls.Add(this.label12);
            this.groupThongTinPhieuNhap.Controls.Add(this.label3);
            this.groupThongTinPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTinPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.groupThongTinPhieuNhap.Name = "groupThongTinPhieuNhap";
            this.groupThongTinPhieuNhap.Size = new System.Drawing.Size(542, 241);
            this.groupThongTinPhieuNhap.TabIndex = 2;
            this.groupThongTinPhieuNhap.TabStop = false;
            this.groupThongTinPhieuNhap.Text = "Thông tin phiếu nhập";
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
            this.label2.Location = new System.Drawing.Point(82, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng tiền : ";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(184, 114);
            this.txtDiaDiem.Multiline = true;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(271, 60);
            this.txtDiaDiem.TabIndex = 12;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(184, 196);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 23);
            this.txtTongTien.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Địa điểm :";
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
            // FrmNhapSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 699);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhapSACH";
            this.Text = "FrmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            this.panelChiTietNhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupThongTinChiTietNhap.ResumeLayout(false);
            this.groupThongTinChiTietNhap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelPhieuNhap.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupThongTinPhieuNhap.ResumeLayout(false);
            this.groupThongTinPhieuNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelChiTietNhap;
        private System.Windows.Forms.GroupBox groupThongTinChiTietNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaChiTietNhap;
        private System.Windows.Forms.Button btnSuaChiTietNhap;
        private System.Windows.Forms.Button btnThemChiTietNhap;
        private System.Windows.Forms.Panel panelPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoaPhieuNhap;
        private System.Windows.Forms.Button btnSuaPhieuNhap;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.GroupBox groupThongTinPhieuNhap;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSACH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTacGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SACHChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaChiTietNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienChiTietNhap;
    }
}