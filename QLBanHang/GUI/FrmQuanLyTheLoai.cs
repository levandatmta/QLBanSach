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
    public partial class FrmQuanLyTheLoai : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyTheLoai()
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
            var dbNV = db.THELOAIs.ToList()
                       .Select(p=> new
                       {
                           ID = p.ID,
                           STT = ++i,
                           Ten = p.TEN
                       })
                       .ToList();

            dgvTheLoai.DataSource = dbNV.Where(p => p.Ten.Contains(keyword))
                                .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvTheLoai.Rows[index].Cells["STT"].Selected = true;
                dgvTheLoai.Select();
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
            txtTenTheLoai.Text = "";
        }

        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                THELOAI tg = getTHELOAIByID();

                if (tg == null || tg.ID == 0) return;
                txtTenTheLoai.Text = tg.TEN;

                index1 = index;
                index = dgvTheLoai.SelectedRows[0].Index;
            }
            catch { }
            
        }

        private THELOAI getTHELOAIByID()
        {
            try
            {
                int id = (int)dgvTheLoai.SelectedRows[0].Cells["ID"].Value;
                THELOAI THELOAI = db.THELOAIs.Where(p => p.ID == id).FirstOrDefault();
                return (THELOAI != null) ? THELOAI : new THELOAI();
            }
            catch
            {
                return new THELOAI();
            }
        }

        private THELOAI getTHELOAIByForm()
        {
            THELOAI ans = new THELOAI();
            ans.TEN = txtTenTheLoai.Text;

            return ans;
        }

        private bool Check()
        {
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Tên thể loại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvTheLoai.Enabled = false;

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
                    dgvTheLoai.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    try
                    {
                        THELOAI tg = getTHELOAIByForm();
                        db.THELOAIs.Add(tg);
                        db.SaveChanges();


                        MessageBox.Show("Thêm thông tin thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Thêm thông tin thể loại thất bại\n"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            THELOAI tg = getTHELOAIByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thông tin thể loại nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvTheLoai.Enabled = false;

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
                    dgvTheLoai.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    THELOAI tgs = getTHELOAIByForm();
                    tg.TEN = tgs.TEN;
                    
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin thể loại thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                THELOAI tg = getTHELOAIByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có thể loại nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin thể loại này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try 
                {

                    var listSach = db.SACHes.Where(p => p.THELOAIID == tg.ID).ToList();
                    foreach (var item in listSach) XoaSach(item);

                    db.THELOAIs.Remove(tg);
                    db.SaveChanges();


                    MessageBox.Show("Xóa thông tin thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thông tin thể loại thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvTheLoai.Enabled = true;

                btnTimKiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }
        #endregion
    }
}
