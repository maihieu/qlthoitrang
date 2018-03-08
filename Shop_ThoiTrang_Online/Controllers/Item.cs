using Shop_ThoiTrang_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class Item
    {
        private Sanpham sanpham = new Sanpham();
        public Sanpham Sanpham
        {

            get { return sanpham; }
            set { sanpham = value; }
        }
        private int soluong;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public Item() { }

        public Item(Sanpham sanpham, int quantity)
        {
            this.sanpham = sanpham;
            this.soluong = quantity;
        }



    }
}