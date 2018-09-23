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
    public partial class FrmQuanLyNXB : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyNXB()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadControl()
        {
            groupThongTin.Enabled = false;
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.NXBs.ToList()
                       .Select(p=> new
                       {
                           ID = p.ID,
                           STT = ++i,
                           Ten = p.TENNXB
                       })
                       .ToList();

            dgvNXB.DataSource = dbNV
                                    .Where(p => p.Ten.Contains(keyword))
                                    .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvNXB.Rows[index].Cells["STT"].Selected = true;
                dgvNXB.Select();
            }
            catch { }
        }


        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadDgvNhanVien();
        }
        #endregion

        #region Hàm chức năng
        
        private void ClearControl()
        {
            txtTenNXB.Text = "";
        }

        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                NXB tg = getNXBByID();

                if (tg == null || tg.ID == 0) return;
                txtTenNXB.Text = tg.TENNXB;

                index1 = index;
                index = dgvNXB.SelectedRows[0].Index;
            }
            catch { }
            
        }

        private NXB getNXBByID()
        {
            try
            {
                int id = (int)dgvNXB.SelectedRows[0].Cells["ID"].Value;
                NXB nxb = db.NXBs.Where(p => p.ID == id).FirstOrDefault();
                return (nxb != null) ? nxb : new NXB();
            }
            catch
            {
                return new NXB();
            }
        }

        private NXB getNXBByForm()
        {
            NXB ans = new NXB();
            ans.TENNXB = txtTenNXB.Text;

            return ans;
        }

        private bool Check()
        {
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Tên nhà xuất bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void XoaSach(SACH tg)
        {
            try
            {
                db.KHOes.RemoveRange(db.KHOes.Where(p => p.SACHID == tg.ID));
                db.CHITIETNHAPs.RemoveRange(db.CHITIETNHAPs.Where(p => p.SACHID == tg.ID));
                db.CHITIETXUATs.RemoveRange(db.CHITIETXUATs.Where(p => p.SACHID == tg.ID));
                db.SaveChanges();

                db.SACHes.Remove(tg);
                db.SaveChanges();
            }
            catch { }
        }

        #endregion

        #region sự kiện ngầm
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }
        #endregion

        #region sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDgvNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvNXB.Enabled = false;

                btnTimKiem.Enabled = false;
                txtTimKiem.Enabled = false;

                ClearControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {

                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongTin.Enabled = false;
                    dgvNXB.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    try
                    {
                        NXB tg = getNXBByForm();
                        db.NXBs.Add(tg);
                        db.SaveChanges();


                        MessageBox.Show("Thêm thông tin nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Thêm thông tin nhà xuất bản thất bại\n"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NXB tg = getNXBByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thông tin nhà xuất bản nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvNXB.Enabled = false;

                btnTimKiem.Enabled = false;
                txtTimKiem.Enabled = false;
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongTin.Enabled = false;
                    dgvNXB.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    NXB tgs = getNXBByForm();
                    tg.TENNXB = tgs.TENNXB;
                    
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin nhà xuất bản  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin nhà xuất bản thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                NXB tg = getNXBByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có nhà xuất bản nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin nhà xuất bản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try 
                {

                    var listSach = db.SACHes.Where(p => p.NXBID == tg.ID).ToList();
                    foreach (var item in listSach) XoaSach(item);

                    db.NXBs.Remove(tg);
                    db.SaveChanges();


                    MessageBox.Show("Xóa thông tin nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thông tin nhà xuất bản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvNhanVien();

                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnXoa.Text = "Xóa";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnSua.Enabled = true;

                groupThongTin.Enabled = false;
                dgvNXB.Enabled = true;

                btnTimKiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }
        #endregion
    }
}
