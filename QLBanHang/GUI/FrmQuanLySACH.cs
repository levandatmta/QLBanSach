﻿using QLBanHang.Data;
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
    public partial class FrmQuanLySACH : Form
    {
        private QLBanSACH_DbContext db = Service.DBService.db;
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLySACH()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadControl()
        {
            groupThongTin.Enabled = false;

            cbxNhaXuatBan.DataSource = db.NXBs.ToList();
            cbxNhaXuatBan.ValueMember = "ID";
            cbxNhaXuatBan.DisplayMember = "TENNXB";

            cbxTheLoai.DataSource = db.THELOAIs.ToList();
            cbxTheLoai.ValueMember = "ID";
            cbxTheLoai.DisplayMember = "TEN";
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.SACHes.ToList()
                       .Select(p=> new
                       {
                           ID = p.ID,
                           STT = ++i,
                           TenMH = p.TEN,
                           TacGia = p.TACGIA,
                           TenNXB = db.NXBs.Where(z=>z.ID == p.NXBID).FirstOrDefault().TENNXB,
                           TheLoai = db.THELOAIs.Where(z=>z.ID == p.THELOAIID).FirstOrDefault().TEN
                       })
                       .ToList();

            dgvSACH.DataSource = dbNV
                                 .Where(p => p.TenMH.Contains(keyword) || p.TacGia.Contains(keyword) || p.TenNXB.Contains(keyword) || p.TheLoai.Contains(keyword))
                                 .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvSACH.Rows[index].Cells["STT"].Selected = true;
                dgvSACH.Select();
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
            try
            {
                txtMASACH.Text = "";
                txtTenMH.Text = "";
                txtTacGia.Text = "";
                txtGhiChu.Text = "";
                cbxNhaXuatBan.SelectedIndex = 0;
                txtGiaBan.Text = "0";
                cbxTheLoai.SelectedIndex = 0;
            }
            catch { }
        }

        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                SACH tg = getSACHByID();

                if (tg == null || tg.ID == 0) return;

                // cập nhật trên giao diện
                txtMASACH.Text = tg.MASACH;
                txtTenMH.Text = tg.TEN;
                txtGhiChu.Text = tg.GHICHU;
                txtTacGia.Text = tg.TACGIA;
                cbxNhaXuatBan.SelectedValue = tg.NXBID;
                txtGiaBan.Text = tg.GIABAN.ToString();
                cbxTheLoai.SelectedValue = tg.THELOAIID;

                index1 = index;
                index = dgvSACH.SelectedRows[0].Index;
            }
            catch { }
            
        }

        private SACH getSACHByID()
        {
            try
            {
                int id = (int)dgvSACH.SelectedRows[0].Cells["ID"].Value;
                SACH nhanvien = db.SACHes.Where(p => p.ID == id).FirstOrDefault();
                return (nhanvien != null) ? nhanvien : new SACH();
            }
            catch
            {
                return new SACH();
            }
        }

        private SACH getSACHByForm()
        {
            SACH ans = new SACH();
            ans.MASACH = txtMASACH.Text;
            ans.TEN = txtTenMH.Text;
            ans.TACGIA = txtTacGia.Text;
            ans.GHICHU = txtGhiChu.Text;
            ans.NXBID = (int) cbxNhaXuatBan.SelectedValue;
            ans.GIABAN = Int32.Parse(txtGiaBan.Text);
            ans.THELOAIID = (int) cbxTheLoai.SelectedValue;

            return ans;
        }

        private bool Check()
        {
            if (txtMASACH.Text == "")
            {
                MessageBox.Show("Mã sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.SACHes.Where(p => p.MASACH == txtMASACH.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    SACH tg = getSACHByID();
                    if (tg.MASACH == txtMASACH.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Mã sách đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txtTenMH.Text == "")
            {
                MessageBox.Show("Tên đầu sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giaban = Int32.Parse(txtGiaBan.Text);
            }
            catch
            {
                MessageBox.Show("Giá bán phải là số nguyên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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

       
    }
}