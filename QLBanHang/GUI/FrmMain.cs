using QLBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.GUI
{
    public partial class FrmMain : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;
        private NHANVIEN nv = new NHANVIEN();

        #region constructor
        public FrmMain(NHANVIEN _nv)
        {
            InitializeComponent();
            Service.DBService.Reload();
            nv = _nv;
        }
        #endregion

        #region LoadForm

        private void LoadPhanQuyen()
        {
            if (nv.QUYEN == 1)
            {
                // phan quyen admin
                btnQLNhanVien.Enabled = true;
                btnQLNXB.Enabled = true;
                btnQLKho.Enabled = true;
                btnTheLoai.Enabled = true;
                btnXuatHang.Enabled = true;
                btnNhapHang.Enabled = true;
                btnQuanLySACH.Enabled = true;
                return;
            }

            if (nv.QUYEN == 0)
            {
                // phan quyen nhan vien
                btnQLNhanVien.Enabled = false;
                btnQLNXB.Enabled = false;
                btnQuanLySACH.Enabled = false;
                btnTheLoai.Enabled = false;
                btnQLKho.Enabled = true;
                btnXuatHang.Enabled = true;
                btnNhapHang.Enabled = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadPhanQuyen();
            txtTTNhanVien.Text = nv.TEN + " - " + ((nv.QUYEN == 0) ? "Nhân viên" : "Quản trị");
        }
        #endregion

        #region sự kiện
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanVien form = new FrmQuanLyNhanVien();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnQLSACH_Click(object sender, EventArgs e)
        {
            FrmQuanLyNXB form = new FrmQuanLyNXB();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }
        private void btnQLKho_Click(object sender, EventArgs e)
        {
            FrmKho form = new FrmKho();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FrmNhapSACH form = new FrmNhapSACH(nv);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            FrmBanSACH form = new FrmBanSACH(nv);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }
        
        private void txtDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau(nv);
            form.ShowDialog();
        }
        #endregion

        private void txtDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;

            this.Close();
        }

        private void btnQuanLySACH_Click(object sender, EventArgs e)
        {
            FrmQuanLySACH form = new FrmQuanLySACH();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            FrmQuanLyTheLoai form = new FrmQuanLyTheLoai();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }
    }
}
