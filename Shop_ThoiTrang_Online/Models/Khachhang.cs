//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_ThoiTrang_Online.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khachhang()
        {
            this.Chuyenkhoans = new HashSet<Chuyenkhoan>();
            this.Dondathangs = new HashSet<Dondathang>();
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public int makh { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string tenkh { get; set; }
        public string diachi { get; set; }
        public Nullable<int> dienthoai { get; set; }
        public string gioitinh { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chuyenkhoan> Chuyenkhoans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dondathang> Dondathangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual Phanhoi Phanhoi { get; set; }
    }
}
