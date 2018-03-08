using Shop_ThoiTrang_Online.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Areas.Admin.Controllers
{
    public class QuanlyController : Controller
    {
        // GET: Admin/Quanly
        QLQUANAOEntities db = new QLQUANAOEntities();
        public ActionResult danh_sach_san_pham()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var sp = from i in splist select i;
            return View(sp);
        }



        public ActionResult them_san_pham()
        {
            return View();
        }

        [HttpPost]
        public ActionResult them_san_pham(SanphamModelView spvm) {
            db = new QLQUANAOEntities();
            Sanpham sp = new Sanpham();
            sp.tensp = spvm.tensp;
            sp.loaisp = spvm.loaisp;
            sp.dongia = spvm.dongia;
            sp.giakhuyenmai = spvm.giakhuyenmai;
            sp.gianhap = spvm.gianhap;
            sp.hangsx = spvm.hangsx;
            sp.mota = spvm.mota;
            sp.tinhtrang = spvm.tinhtrang;
            sp.size = spvm.size;
            sp.soluong = spvm.soluong;


            db.Sanphams.Add(sp);
            db.SaveChanges();
            return RedirectToAction("them_san_pham", "Quanly", "Admin");
        }

        public ActionResult Edit(int masp)
        {
            db = new QLQUANAOEntities();
            Sanpham sp = db.Sanphams.SingleOrDefault(x => x.masp == masp);
            SanphamModelView spView = new SanphamModelView();
            spView.masp = sp.masp;
            spView.tensp = sp.tensp;
            spView.dongia = sp.dongia;
            spView.giakhuyenmai = sp.giakhuyenmai;
            spView.soluong = sp.soluong;
            spView.size = sp.size;
            spView.hangsx = sp.hangsx;
            spView.gianhap = sp.gianhap;
            spView.loaisp = sp.loaisp;
            spView.khuyenmai = sp.khuyenmai;
            spView.tinhtrang = sp.tinhtrang;
            spView.mota = sp.mota;
            spView.hinhanh = sp.hinhanh;
           



            return View(spView);
        }
       
        [HttpPost]
        public ActionResult Edit(Sanpham sp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("danh_sach_san_pham");
            }
            return View(sp);
        }
        public ActionResult Delete(int id)
        {
            Sanpham sp = db.Sanphams.Find(id);
         

            return View(sp);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Sanpham sp = db.Sanphams.Find(id);
            db.Sanphams.Remove(sp);
            db.SaveChanges();
            return RedirectToAction("danh_sach_san_pham");
        }









        public ActionResult danh_sach_khach_hang() {
            db = new QLQUANAOEntities();
            List<Khachhang> lkh = db.Khachhangs.ToList();
            var kh = from i in lkh select i;
            return View(kh);
        }

        public ActionResult don_hang() {
            db = new QLQUANAOEntities();
            List<Dondathang> dh = db.Dondathangs.ToList();
            var lkh = from i in dh select i;
            return View(lkh);

        }

        public ActionResult chi_tiet_don_hang(int madh) {
            db = new QLQUANAOEntities();
            ChitietDonhang ctdh = db.ChitietDonhangs.SingleOrDefault(x=> x.madh == madh);
            ChitietdonhangViewModel ct = new ChitietdonhangViewModel();
            ct.mactdh = ctdh.mactdh ;
            ct.madh = ctdh.madh;
            ct.masp = Convert.ToInt32(ctdh.masp);
            ct.makh = ctdh.makh;
            ct.tensp = ctdh.tensp;
            ct.hinhanh = ct.hinhanh;
            ct.ngaydat =  ct.ngaydat;

            return View(ct);
        }
    }
}