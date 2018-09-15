namespace QLBanHang.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHO")]
    public partial class KHO
    {
        public int ID { get; set; }

        public int? SACHID { get; set; }

        public int? SOLUONG { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
