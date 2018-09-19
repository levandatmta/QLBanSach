namespace QLBanHang.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
            CHITIETXUATs = new HashSet<CHITIETXUAT>();
            KHOes = new HashSet<KHO>();
        }

        public int ID { get; set; }

        public string MASACH { get; set; }

        public string TEN { get; set; }

        public string TACGIA { get; set; }

        public string GHICHU { get; set; }

        public int? NXBID { get; set; }

        public int? THELOAIID { get; set; }

        public int? GIABAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETXUAT> CHITIETXUATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO> KHOes { get; set; }

        public virtual NXB NXB { get; set; }

        public virtual THELOAI THELOAI { get; set; }
    }
}
