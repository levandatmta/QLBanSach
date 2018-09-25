using QLBanHang.Data;
using QLBanHang.Service;
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
    public partial class FrmLogin : Form
    {
        private QLBanSACH_DbContext db = DBService.db;
        
        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            DBService.Reload();
        }
        #endregion

        #region Sự kiện
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.Where(p => p.TAIKHOAN == txtTenDangNhap.Text && p.MATKHAU == txtMatKhau.Text).FirstOrDefault();
            
            if (nv == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmMain form = new FrmMain(nv);
            this.Hide();
            form.ShowDialog();
            this.Show();            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
