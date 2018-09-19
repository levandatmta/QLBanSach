namespace QLBanHang.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETXUAT")]
    public partial class CHITIETXUAT
    {
        public int ID { get; set; }

        public int? HOADONBANID { get; set; }

        public int? SACHID { get; set; }

        public int? SOLUONG { get; set; }

        public int? GIABAN { get; set; }

        public int? THANHTIEN { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
