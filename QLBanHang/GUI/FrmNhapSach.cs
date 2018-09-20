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
    public partial class FrmNhapSACH : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;
        private int indexPhieuNhap = 0, indexPhieuNhap1 = 0;
        private int indexChiTietNhap = 0, indexChiTietNhap1 = 0;
        private NHANVIEN nv = new NHANVIEN();

        #region constructor
        public FrmNhapSACH(NHANVIEN _nv)
        {
            InitializeComponent();
            Service.DBService.Reload();
            nv = _nv;
        }
        #endregion

        #region Form chính
        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            LoadChiTietNhap();
        }
        #endregion

        #region Phiếu nhập

        #region Load
        private void LoadInitControl()
        {
            // cbx Nhân viên
            cbxNhanVien.DataSource = db.NHANVIENs.ToList();
            cbxNhanVien.ValueMember = "ID";
            cbxNhanVien.DisplayMember = "TEN";

            dateNgayNhap.Value = DateTime.Now;

            groupThongTinPhieuNhap.Enabled = false;

        }

        private void LoadDgvPhieuNhap()
        {
            int i = 0;
            var dataPhieuNhap = db.PHIEUNHAPs.ToList()
                                .Select(p => new
                                {
                                    ID = p.ID,
                                    STT = ++i,
                                    Ngay = ((DateTime)p.NGAY).ToString("dd/MM/yyyy"),
                                    NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN,
                                    DiaDiem = p.DIADIEM,
                                    TongTien = p.TONGTIEN
                                })
                                .ToList();
            dgvPhieuNhap.DataSource = dataPhieuNhap;

            // thêm index 
            indexPhieuNhap = indexPhieuNhap1;
            try
            {
                dgvPhieuNhap.Rows[indexPhieuNhap].Cells["STTPhieuNhap"].Selected = true;
                dgvPhieuNhap.Select();
            }
            catch { }

            LoadDgvChiTietNhap();
        }

        private void LoadPhieuNhap()
        {
            LoadInitControl();
            LoadDgvPhieuNhap();
        }
        #endregion

        #region Hàm chức năng

        private void UpdateDetailPhieuNhap()
        {
            ClearControlPhieuNhap();
            PHIEUNHAP tg = getPhieuNhapByID();
            if (tg.ID == 0) return;

            int TongTienCu = (int) tg.TONGTIEN;

            try
            {
                try
                {

                    int cnt = 0;
                    cnt = db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == tg.ID).ToList().Count;
                    if (cnt == 0) tg.TONGTIEN = 0;

                    
                    tg.TONGTIEN = db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == tg.ID).Sum(p => p.THANHTIEN).Value;
                    
                }
                catch { tg.TONGTIEN = 0; }

                if (TongTienCu != tg.TONGTIEN) LoadDgvPhieuNhap();
                db.SaveChanges();

                cbxNhanVien.SelectedValue = tg.NHANVIENID;
                dateNgayNhap.Value = (DateTime)tg.NGAY;
                txtDiaDiem.Text = tg.DIADIEM;
                txtTongTien.Text = tg.TONGTIEN.ToString();
                

                indexPhieuNhap1 = indexPhieuNhap;
                indexPhieuNhap = dgvPhieuNhap.SelectedRows[0].Index;

                
                LoadDgvChiTietNhap();
            }
            catch { }
        }

        private void ClearControlPhieuNhap()
        {
            try
            {
                cbxNhanVien.SelectedValue = (int)nv.ID;
                dateNgayNhap.Value = DateTime.Now;
                txtDiaDiem.Text = "";
                txtTongTien.Text = "";
            }
            catch { }
        }

        private bool CheckPhieuNhap()
        {
            if (txtDiaDiem.Text == "")
            {
                MessageBox.Show("Địa điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private PHIEUNHAP getPhieuNhapByID()
        {
            PHIEUNHAP ans = new PHIEUNHAP();

            try
            {
                int id = (int)dgvPhieuNhap.SelectedRows[0].Cells["IDPhieuNhap"].Value;
                PHIEUNHAP z = db.PHIEUNHAPs.Where(p => p.ID == id).FirstOrDefault();

                if (z != null) ans = z;
            }
            catch { }

            return ans;
        }

        private PHIEUNHAP getPhieuNhapByForm()
        {
            PHIEUNHAP ans = new PHIEUNHAP();

            ans.NHANVIENID = (int)cbxNhanVien.SelectedValue;
            ans.NGAY = dateNgayNhap.Value;
            ans.DIADIEM = txtDiaDiem.Text;
            ans.TONGTIEN = 0;
            //ans.TONGTIEN = Int32.Parse(txtTongTien.Text);

            return ans;
        }

        #endregion

        #region Sự kiện ngầm

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetailPhieuNhap();
        }

        #endregion

        #region Sự kiện
        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (btnThemPhieuNhap.Text == "Thêm")
            {

                btnThemPhieuNhap.Text = "Lưu";
                btnSuaPhieuNhap.Enabled = false;
                btnXoaPhieuNhap.Text = "Hủy";

                groupThongTinPhieuNhap.Enabled = true;
                dgvPhieuNhap.Enabled = false;

                panelChiTietNhap.Enabled = false;

                ClearControlPhieuNhap();

                return;
            }

            if (btnThemPhieuNhap.Text == "Lưu")
            {
                if (CheckPhieuNhap())
                {

                    btnThemPhieuNhap.Text = "Thêm";
                    btnSuaPhieuNhap.Enabled = true;
                    btnXoaPhieuNhap.Text = "Xóa";

                    groupThongTinPhieuNhap.Enabled = false;
                    dgvPhieuNhap.Enabled = true;

                    panelChiTietNhap.Enabled = true;


                    try
                    {
                        PHIEUNHAP tg = getPhieuNhapByForm();
                        db.PHIEUNHAPs.Add(tg);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin phiếu nhập thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvPhieuNhap();
                }

                return;
            }
        }

        private void btnSuaPhieuNhap_Click(object sender, EventArgs e)
        {
            PHIEUNHAP tg = getPhieuNhapByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSuaPhieuNhap.Text == "Sửa")
            {
                btnSuaPhieuNhap.Text = "Lưu";
                btnThemPhieuNhap.Enabled = false;
                btnXoaPhieuNhap.Text = "Hủy";

                groupThongTinPhieuNhap.Enabled = true;
                dgvPhieuNhap.Enabled = false;

                panelChiTietNhap.Enabled = false;

                return;
            }

            if (btnSuaPhieuNhap.Text == "Lưu")
            {
                if (CheckPhieuNhap())
                {
                    btnSuaPhieuNhap.Text = "Sửa";
                    btnThemPhieuNhap.Enabled = true;
                    btnXoaPhieuNhap.Text = "Xóa";

                    groupThongTinPhieuNhap.Enabled = false;
                    dgvPhieuNhap.Enabled = true;

                    panelChiTietNhap.Enabled = true;

                    PHIEUNHAP tgs = getPhieuNhapByForm();
                    tg.NHANVIENID = tgs.NHANVIENID;
                    tg.NGAY = tgs.NGAY;
                    tg.DIADIEM = tgs.DIADIEM;
                    tg.TONGTIEN = tgs.TONGTIEN;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin phiếu nhập thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDgvPhieuNhap();
                }

                return;
            }
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (btnXoaPhieuNhap.Text == "Xóa")
            {
                PHIEUNHAP tg = getPhieuNhapByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có phiếu nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.CHITIETNHAPs.RemoveRange(db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == tg.ID));
                    db.SaveChanges();

                    db.PHIEUNHAPs.Remove(tg);
                    db.SaveChanges();
                    MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa phiếu nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvPhieuNhap();

                return;
            }

            if (btnXoaPhieuNhap.Text == "Hủy")
            {
                btnXoaPhieuNhap.Text = "Xóa";
                btnThemPhieuNhap.Text = "Thêm";
                btnSuaPhieuNhap.Text = "Sửa";

                btnThemPhieuNhap.Enabled = true;
                btnSuaPhieuNhap.Enabled = true;

                groupThongTinPhieuNhap.Enabled = false;
                dgvPhieuNhap.Enabled = true;

                panelChiTietNhap.Enabled = true;

                UpdateDetailPhieuNhap();

                return;
            }
        }

        #endregion

        #endregion

        #region Chi tiết nhập

        #region Load
        private void LoadInitControlChiTietNhap()
        {
            // cbx Nhân viên
            cbxSACH.DataSource = db.SACHes.ToList();
            cbxSACH.ValueMember = "ID";
            cbxSACH.DisplayMember = "TEN";

            groupThongTinChiTietNhap.Enabled = false;

        }

        private void LoadDgvChiTietNhap()
        {

            int idPhieuNhap = 0;
            try
            {
                idPhieuNhap = (int)dgvPhieuNhap.SelectedRows[0].Cells["IDPhieuNhap"].Value;
            }
            catch
            {
            }

            int i = 0;
            var dataChiTietNhap = db.CHITIETNHAPs.ToList()
                                  .Where(p=>p.SACHID != null)
                                  .Where(p => p.PHIEUNHAPID == idPhieuNhap)
                                  .Select(p => new
                                  {
                                      ID = p.ID,
                                      STT = ++i,
                                      SACH = db.SACHes.Where(z=>z.ID == p.SACHID).FirstOrDefault().TEN,
                                      SoLuong = p.SOLUONG,
                                      DonGia = p.DONGIA,
                                      ThanhTien = p.THANHTIEN
                                  })
                                  .ToList();
            dgvChiTietNhap.DataSource = dataChiTietNhap;

            // thêm index 
            indexChiTietNhap = indexChiTietNhap1;
            try
            {
                dgvChiTietNhap.Rows[indexChiTietNhap].Cells["STTChiTietNhap"].Selected = true;
                dgvChiTietNhap.Select();
            }
            catch { }
        }

        private void LoadChiTietNhap()
        {
            LoadInitControlChiTietNhap();
            LoadDgvChiTietNhap();
        }
        #endregion

        #region Hàm chức năng

        private void UpdateDetailChiTietNhap()
        {
            ClearControlChiTietNhap();
            CHITIETNHAP tg = getChiTietNhapByID();
            if (tg.ID == 0) return;

            try
            {
                cbxSACH.SelectedValue = (int) tg.SACHID;
                txtSoLuong.Text = tg.SOLUONG.ToString();
                txtDonGia.Text = tg.DONGIA.ToString();
                txtThanhTien.Text = tg.THANHTIEN.ToString();

                indexChiTietNhap1 = indexChiTietNhap;
                indexChiTietNhap = dgvChiTietNhap.SelectedRows[0].Index;
            }
            catch { }
        }

        private void ClearControlChiTietNhap()
        {
            try
            {
                cbxSACH.SelectedIndex = 0;
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
                txtThanhTien.Text = "";
            }
            catch { }
        }

        private bool CheckChiTietNhap()
        {
            // số lượng
            try
            {
                int k = Int32.Parse(txtSoLuong.Text);
                if (k == 0) k = 3 / k;
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // đơn giá
            try
            {
                int k = Int32.Parse(txtDonGia.Text);
            }
            catch
            {
                MessageBox.Show("Đơn giá phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private CHITIETNHAP getChiTietNhapByID()
        {
            CHITIETNHAP ans = new CHITIETNHAP();

            try
            {
                int id = (int)dgvChiTietNhap.SelectedRows[0].Cells["IDChiTietNhap"].Value;
                CHITIETNHAP z = db.CHITIETNHAPs.Where(p => p.ID == id).FirstOrDefault();

                if (z != null) ans = z;
            }
            catch { }

            return ans;
        }

        private CHITIETNHAP getChiTietNhapByForm()
        {
            CHITIETNHAP ans = new CHITIETNHAP();

            try
            {
                int idPhieuNhap;
                ans.SACHID = (int) cbxSACH.SelectedValue;
                ans.SOLUONG = Int32.Parse(txtSoLuong.Text);
                ans.DONGIA = Int32.Parse(txtDonGia.Text);
                ans.THANHTIEN = ans.SOLUONG * ans.DONGIA;

                idPhieuNhap = (int)dgvPhieuNhap.SelectedRows[0].Cells["IDPhieuNhap"].Value;
                ans.PHIEUNHAPID = idPhieuNhap;
            }
            catch { }

            return ans;
        }

        #endregion

        #region Sự kiện ngầm

        private void dgvChiTietNhap_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetailChiTietNhap();
        }

        private void cbxSACH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int) cbxSACH.SelectedValue;
                txtTacGia.Text = db.SACHes.Where(p => p.ID == id).FirstOrDefault().TACGIA;
            }
            catch { }
        }

        #endregion

        #region Sự kiện
        private void btnThemChiTietNhap_Click(object sender, EventArgs e)
        {
            

            if (btnThemChiTietNhap.Text == "Thêm")
            {

                // kiểm tra quyền của nhân viên
                PHIEUNHAP z = getPhieuNhapByID();
                if (z.ID == 0)
                {
                    MessageBox.Show("Chưa có phiếu nhập nào được lựa chọn",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                NHANVIEN nvtg = db.NHANVIENs.Where(p => p.ID == z.NHANVIENID).FirstOrDefault();

                if (nv.QUYEN == 0 && nv.ID != nvtg.ID)
                {
                    // nếu nhân viên không phải là admin và không phải nhân viên nhập phiếu thì thông báo
                    MessageBox.Show("Bạn không có quyền thêm chi tiết nhập\nChỉ quản trị và nhân viên nhập phiếu mới có quyền thêm chi tiết nhập",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                btnThemChiTietNhap.Text = "Lưu";
                btnSuaChiTietNhap.Enabled = false;
                btnXoaChiTietNhap.Text = "Hủy";

                groupThongTinChiTietNhap.Enabled = true;
                dgvChiTietNhap.Enabled = false;

                panelPhieuNhap.Enabled = false;

                ClearControlChiTietNhap();

                return;
            }

            if (btnThemChiTietNhap.Text == "Lưu")
            {
                if (CheckChiTietNhap())
                {

                    btnThemChiTietNhap.Text = "Thêm";
                    btnSuaChiTietNhap.Enabled = true;
                    btnXoaChiTietNhap.Text = "Xóa";

                    groupThongTinChiTietNhap.Enabled = false;
                    dgvChiTietNhap.Enabled = true;

                    panelPhieuNhap.Enabled = true;


                    try
                    {
                        CHITIETNHAP tg = getChiTietNhapByForm();
                        db.CHITIETNHAPs.Add(tg);
                        db.SaveChanges();

                        KHO kho = db.KHOes.Where(p => p.SACHID == tg.SACHID).FirstOrDefault();
                        kho.SOLUONG += tg.SOLUONG;
                        db.SaveChanges();

                        MessageBox.Show("Thêm thông tin Chi tiết nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin Chi tiết nhập thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvChiTietNhap();
                    UpdateDetailPhieuNhap();
                }

                return;
            }
        }

        private void btnSuaChiTietNhap_Click(object sender, EventArgs e)
        {
            // kiểm tra quyền của nhân viên
            PHIEUNHAP z = getPhieuNhapByID();
            if (z.ID == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập nào được lựa chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            NHANVIEN nvtg = db.NHANVIENs.Where(p => p.ID == z.NHANVIENID).FirstOrDefault();

            if (nv.QUYEN == 0 && nv.ID != nvtg.ID)
            {
                // nếu nhân viên không phải là admin và không phải nhân viên nhập phiếu thì thông báo
                MessageBox.Show("Bạn không có quyền sửa chi tiết nhập\nChỉ quản trị và nhân viên nhập phiếu mới có quyền sửa chi tiết nhập",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // kiểm tra xem có chi tiết nhập nào được chọn k
            CHITIETNHAP tg = getChiTietNhapByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có Chi tiết nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSuaChiTietNhap.Text == "Sửa")
            {
                btnSuaChiTietNhap.Text = "Lưu";
                btnThemChiTietNhap.Enabled = false;
                btnXoaChiTietNhap.Text = "Hủy";

                groupThongTinChiTietNhap.Enabled = true;
                dgvChiTietNhap.Enabled = false;

                panelPhieuNhap.Enabled = false;

                return;
            }

            if (btnSuaChiTietNhap.Text == "Lưu")
            {
                if (CheckChiTietNhap())
                {
                    btnSuaChiTietNhap.Text = "Sửa";
                    btnThemChiTietNhap.Enabled = true;
                    btnXoaChiTietNhap.Text = "Xóa";

                    groupThongTinChiTietNhap.Enabled = false;
                    dgvChiTietNhap.Enabled = true;

                    panelPhieuNhap.Enabled = true;

                    CHITIETNHAP tgs = getChiTietNhapByForm();
                    tg.SACHID = tgs.SACHID;
                    tg.SOLUONG = tgs.SOLUONG;
                    tg.DONGIA = tgs.DONGIA;
                    tg.THANHTIEN = tgs.THANHTIEN;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin Chi tiết nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin Chi tiết nhập thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDgvChiTietNhap();

                    UpdateDetailPhieuNhap();
                }

                return;
            }
        }

        private void btnXoaChiTietNhap_Click(object sender, EventArgs e)
        {
            if (btnXoaChiTietNhap.Text == "Xóa")
            {
                // kiểm tra quyền của nhân viên
                PHIEUNHAP z = getPhieuNhapByID();
                if (z.ID == 0)
                {
                    MessageBox.Show("Chưa có phiếu nhập nào được lựa chọn",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                NHANVIEN nvtg = db.NHANVIENs.Where(p => p.ID == z.NHANVIENID).FirstOrDefault();

                if (nv.QUYEN == 0 && nv.ID != nvtg.ID)
                {
                    // nếu nhân viên không phải là admin và không phải nhân viên nhập phiếu thì thông báo
                    MessageBox.Show("Bạn không có quyền xóa chi tiết nhập\nChỉ quản trị và nhân viên nhập phiếu mới có quyền xóa chi tiết nhập",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // kiểm tra xem trong bảng có chi tiết nhập k
                CHITIETNHAP tg = getChiTietNhapByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có Chi tiết nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin Chi tiết nhập này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.CHITIETNHAPs.Remove(tg);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Chi tiết nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa Chi tiết nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvChiTietNhap();
                UpdateDetailPhieuNhap();

                return;
            }

            if (btnXoaChiTietNhap.Text == "Hủy")
            {
                btnXoaChiTietNhap.Text = "Xóa";
                btnThemChiTietNhap.Text = "Thêm";
                btnSuaChiTietNhap.Text = "Sửa";

                btnThemChiTietNhap.Enabled = true;
                btnSuaChiTietNhap.Enabled = true;

                groupThongTinChiTietNhap.Enabled = false;
                dgvChiTietNhap.Enabled = true;

                panelPhieuNhap.Enabled = true;

                UpdateDetailChiTietNhap();
                

                return;
            }
        }

        #endregion

        #endregion

    }
}
