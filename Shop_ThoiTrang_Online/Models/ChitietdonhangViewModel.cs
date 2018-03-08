using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop_ThoiTrang_Online.Models
{
    public class ChitietdonhangViewModel
    {
        public int mactdh { get; set; }
        public Nullable<int> madh { get; set; }
        public int masp { get; set; }
        public string tensp { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<double> dongia { get; set; }
        public Nullable<double> thanhtien { get; set; }
        public Nullable<System.DateTime> ngaydat { get; set; }
        public Nullable<System.DateTime> ngaygiao { get; set; }
        public string tinhtrangdon { get; set; }
        public string hinhthucthanhtoan { get; set; }
        public Nullable<int> makh { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public Nullable<int> sdt { get; set; }
        public string hinhanh { get; set; }

        public virtual Dondathang Dondathang { get; set; }
    }
}