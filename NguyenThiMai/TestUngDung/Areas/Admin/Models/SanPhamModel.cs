using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUngDung.Areas.Admin.Models
{
    public class SanPhamModel
    {
        public String IDSP { get; set; }
        public String TenSP { get; set; }

        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public String MoTa { get; set; }
        public String LoaiSP_ID { get; set; }
    }
}