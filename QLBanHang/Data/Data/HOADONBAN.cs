namespace QLBanHang.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBAN")]
    public partial class HOADONBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONBAN()
        {
            CHITIETXUATs = new HashSet<CHITIETXUAT>();
        }

        public int ID { get; set; }

        public int? NHANVIENID { get; set; }

        public DateTime? NGAY { get; set; }

        public int? TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETXUAT> CHITIETXUATs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
