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
    public partial class FrmKho : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;

        #region constructor
        public FrmKho()
        {
            InitializeComponent();
            Service.DBService.Reload();
        }

        #endregion

        #region LoadForm
        private void LoadDgvSACH()
        {

            string keyword = txtTimKiem.Text;

            try
            {
                int i = 0;
                var dataSACH = db.KHOes.ToList()
                                  .Select(p => new
                                  {
                                      STT = ++i,
                                      SACH = db.SACHes.Where(z => z.ID == p.SACHID).FirstOrDefault().TEN,
                                      TacGia = db.SACHes.Where(z => z.ID == p.SACHID).FirstOrDefault().TACGIA,
                                      TheLoai = db.THELOAIs.Where(z=>z.ID == db.SACHes.Where(y=>y.ID == p.SACHID).FirstOrDefault().THELOAIID).FirstOrDefault().TEN,
                                      SoLuong = p.SOLUONG
                                  })
                                  .Where(p => p.SACH.Contains(keyword) || p.TacGia.Contains(keyword))
                                  .ToList();

                dgvSACH.DataSource = dataSACH;
            }
            catch { }
        }
        private void FrmKho_Load(object sender, EventArgs e)
        {
            LoadDgvSACH();
        }
        #endregion

        #region sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDgvSACH();
        }
        #endregion
    }
}
