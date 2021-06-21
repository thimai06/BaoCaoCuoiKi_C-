namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanNguoiDung")]
    public partial class TaiKhoanNguoiDung
    {
        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [StringLength(255)]
        public string MatKhau { get; set; }

        [StringLength(255)]
        public string Trangthai { get; set; }
    }
}
