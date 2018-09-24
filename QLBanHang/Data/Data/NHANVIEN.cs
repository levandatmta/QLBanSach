namespace QLBanHang.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONBANs = new HashSet<HOADONBAN>();
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }

        public int ID { get; set; }

        public string MANV { get; set; }

        public string TEN { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public int? GIOITINH { get; set; }

        public string SDT { get; set; }

        public string DIACHI { get; set; }

        public int? QUYEN { get; set; }

        public string MATKHAU { get; set; }

        public string TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBAN> HOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
