using Microsoft.Reporting.WinForms;
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

namespace QLBanHang.Report
{
    public partial class FrmRpInHoaDon : Form
    {
        private HOADONBAN hd = new HOADONBAN();

        private QLBanSACH_DbContext db = Service.DBService.db;

        #region constructor
        public FrmRpInHoaDon(HOADONBAN z)
        {
            InitializeComponent();
            Service.DBService.Reload();
            hd = z;
        }
        #endregion

        #region LoadForm
        private void FrmRpInHoaDon_Load(object sender, EventArgs e)
        {

            int i = 0;
            ChiTietBanBindingSource.DataSource = (
                                                    from ctb in db.CHITIETXUATs.Where(p => p.HOADONBANID == hd.ID).ToList()
                                                    from sach in db.SACHes.Where(p => p.ID == ctb.SACHID).ToList()
                                                    select new
                                                    {
                                                        STT = ++i,
                                                        Sach = sach.TEN,
                                                        SoLuong = ctb.SOLUONG,
                                                        GiaBan = ((int) sach.GIABAN).ToString("N0"),
                                                        ThanhTien = ((int) ctb.THANHTIEN).ToString("N0")
                                                    }
                                                  ).ToList();

            // add parameter
            ReportParameter[] listPara = new ReportParameter[]{
                    new ReportParameter("NhanVien", db.NHANVIENs.Where(z=>z.ID == hd.NHANVIENID).FirstOrDefault().TEN),
                    new ReportParameter("ThoiGian", ((DateTime) hd.NGAY).ToString("HH:mm dd/MM/yyyy")),
                    new ReportParameter("TongTien", ((int) hd.TONGTIEN).ToString("N0"))
            };

            this.reportViewer1.LocalReport.SetParameters(listPara);
            this.reportViewer1.RefreshReport();
        }
        #endregion
    }
}
