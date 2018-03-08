using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop_ThoiTrang_Online.Models
{
    public class SanphamModelView
    {
        [Key]
        public int masp { get; set; }
        public string tensp { get; set; }
        public Nullable<double> dongia { get; set; }
        public Nullable<double> giakhuyenmai { get; set; }
        public Nullable<int> soluong { get; set; }
        public string size { get; set; }
        public string hangsx { get; set; }
        public Nullable<double> gianhap { get; set; }
        public string mota { get; set; }
        public string tinhtrang { get; set; }
        public string loaisp { get; set; }
        public string khuyenmai { get; set; }
        public string hinhanh { get; set; }

        public virtual ICollection<Dondathang> Dondathangs { get; set; }

    }
}