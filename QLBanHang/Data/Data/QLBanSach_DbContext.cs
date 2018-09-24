namespace QLBanHang.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLBanSACH_DbContext : DbContext
    {
        public QLBanSACH_DbContext()
            : base("name=QLBanSACH_DbContext")
        {
        }

        public virtual DbSet<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public virtual DbSet<CHITIETXUAT> CHITIETXUATs { get; set; }
        public virtual DbSet<HOADONBAN> HOADONBANs { get; set; }
        public virtual DbSet<KHO> KHOes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
