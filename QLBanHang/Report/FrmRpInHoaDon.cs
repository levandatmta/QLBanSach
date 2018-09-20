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
    }
}
