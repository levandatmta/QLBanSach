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
    public partial class FrmQuanLyNhanVien : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadControl()
        {
            cbxGioiTinh.SelectedIndex = 0;
            groupThongTin.Enabled = false;
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.NHANVIENs.ToList()
                       .Select(p=> new
                       {
                           ID = p.ID,
                           STT = ++i,
                           HoTen = p.TEN,
                           NgaySinh = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy") ,
                           GioiTinh = (p.GIOITINH == 0) ? "Nữ" : "Nam",
                           Quyen = (p.QUYEN == 1) ? "Quản trị" : "Nhân viên"
                       })
                       .OrderByDescending(p=>p.Quyen)
                       .ToList();

            dgvNhanVien.DataSource = dbNV.Where(p => p.HoTen.Contains(keyword) || p.GioiTinh.Contains(keyword) || p.Quyen.Contains(keyword) || p.NgaySinh.Contains(keyword))
                                     .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvNhanVien.Rows[index].Cells["STT"].Selected = true;
                dgvNhanVien.Select();
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
            txtMaNhanVien.Text = "";
            txtHoVaTen.Text = "";
            cbxGioiTinh.SelectedIndex = 0;
            txtSDT.Text = "";
            txtDIACHI.Text = "";
            dateNgaySinh.Value = DateTime.Now;
            txtTaiKhoan.Text = "";
            cbxQuyen.SelectedIndex = 0;
        }

        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                NHANVIEN nhanvien = getNhanVienByID();

                if (nhanvien == null || nhanvien.ID == 0) return;

                // cập nhật trên giao diện
                txtMaNhanVien.Text = nhanvien.MANV;
                txtHoVaTen.Text = nhanvien.TEN;
                cbxGioiTinh.SelectedIndex = (int)nhanvien.GIOITINH;
                txtSDT.Text = nhanvien.SDT;
                txtDIACHI.Text = nhanvien.DIACHI;
                dateNgaySinh.Value = (DateTime)nhanvien.NGAYSINH;
                txtTaiKhoan.Text = nhanvien.TAIKHOAN;
                cbxQuyen.SelectedIndex = (int) nhanvien.QUYEN;

                index1 = index;
                index = dgvNhanVien.SelectedRows[0].Index;
            }
            catch { }
            
        }

        private NHANVIEN getNhanVienByID()
        {
            try
            {
                int id = (int)dgvNhanVien.SelectedRows[0].Cells["ID"].Value;
                NHANVIEN nhanvien = db.NHANVIENs.Where(p => p.ID == id).FirstOrDefault();
                return (nhanvien != null) ? nhanvien : new NHANVIEN();
            }
            catch
            {
                return new NHANVIEN();
            }
        }

        private NHANVIEN getNhanVienByForm()
        {
            NHANVIEN ans = new NHANVIEN();
            ans.MANV = txtMaNhanVien.Text;
            ans.TEN = txtHoVaTen.Text;
            ans.GIOITINH = cbxGioiTinh.SelectedIndex;
            ans.SDT = txtSDT.Text;
            ans.DIACHI = txtDIACHI.Text;
            ans.TAIKHOAN = txtTaiKhoan.Text;
            ans.NGAYSINH = dateNgaySinh.Value;
            ans.QUYEN = cbxQuyen.SelectedIndex;
            ans.MATKHAU = "1";

            return ans;
        }

        private bool Check()
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.NHANVIENs.Where(p => p.MANV == txtMaNhanVien.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    NHANVIEN nv = getNhanVienByID();
                    if (nv.MANV == txtMaNhanVien.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Mã nhân viên đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txtHoVaTen.Text == "")
            {
                MessageBox.Show("Họ và tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            /// check trùng tài khoản
            int id = 0;
            try
            {
                id = (int) dgvNhanVien.SelectedRows[0].Cells["ID"].Value;
            }
            catch
            {

            }
            cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == txtTaiKhoan.Text && id != p.ID).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Tài khoản của nhân viên đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDIACHI.Text == "")
            {
                MessageBox.Show("Địa chỉ của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

            return true;
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
                dgvNhanVien.Enabled = false;

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
                    dgvNhanVien.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    try
                    {
                        NHANVIEN tg = getNhanVienByForm();
                        db.NHANVIENs.Add(tg);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Thêm thông tin mặt hàng thất bại\n"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHANVIEN tg = getNhanVienByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhân viên nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvNhanVien.Enabled = false;

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
                    dgvNhanVien.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    NHANVIEN tgs = getNhanVienByForm();
                    tg.MANV = tgs.MANV;
                    tg.TEN = tgs.TEN;
                    tg.GIOITINH = tgs.GIOITINH;
                    tg.DIACHI = tgs.DIACHI;
                    tg.NGAYSINH = tgs.NGAYSINH;
                    tg.QUYEN = tgs.QUYEN;
                    tg.TAIKHOAN = tgs.TAIKHOAN;
                    
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                NHANVIEN tg = getNhanVienByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có nhân viên nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try 
                {
                    var listCTN =
                            from ctn in db.CHITIETNHAPs.ToList()
                            from pn in db.PHIEUNHAPs.Where(p => p.ID == ctn.PHIEUNHAPID).ToList()
                            from nv in db.NHANVIENs.Where(p => p.ID == pn.NHANVIENID && p.ID == tg.ID)
                            select ctn;

                    var listCTX =
                            from ctn in db.CHITIETXUATs.ToList()
                            from pn in db.HOADONBANs.Where(p => p.ID == ctn.HOADONBANID).ToList()
                            from nv in db.NHANVIENs.Where(p => p.ID == pn.NHANVIENID && p.ID == tg.ID)
                            select ctn;

                    db.CHITIETNHAPs.RemoveRange(listCTN);
                    db.CHITIETXUATs.RemoveRange(listCTX);
                    db.SaveChanges();

                    db.PHIEUNHAPs.RemoveRange(db.PHIEUNHAPs.Where(p => p.NHANVIENID == tg.ID));
                    db.HOADONBANs.RemoveRange(db.HOADONBANs.Where(p => p.NHANVIENID == tg.ID));
                    db.SaveChanges();

                    db.NHANVIENs.Remove(tg);
                    db.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvNhanVien.Enabled = true;

                btnTimKiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }
        #endregion
    }
}
