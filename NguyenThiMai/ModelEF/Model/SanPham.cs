namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(7)]
        [Display(Name = "Mã Sản Phẩm")]
        public string IDSP { get; set; }

        [StringLength(200)]
        [Display(Name = "Tên Sản Phẩm")]
        public string TenSP { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Giá Tiền")]
        public decimal? DonGia { get; set; }
        [Display(Name = "Số Lượng")]
        public int? SoLuong { get; set; }

        [StringLength(255)]

        public string image { get; set; }

        [StringLength(255)]
        [Display(Name = "Mô Tả")]
        public string MoTa { get; set; }

        [StringLength(7)]
        [Display(Name = "Loại Sản Phẩm")]
        public string LoaiSP_ID { get; set; }

        [StringLength(255)]
        public string Trangthai { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
    }
}
