using Shop_ThoiTrang_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class ProductController : Controller
    {
        QLQUANAOEntities db;
        // GET: Sanpham
        public ActionResult details(int masp)
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

        //do nam
        public ActionResult do_nam()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "asmnam" select i).Take(9);
            return View(viewsp);
        }
        public ActionResult so_mi_nam()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "asmnam" select i).Take(9);
            return View(viewsp);
        }

        public ActionResult ao_thun_nam()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "atnam" select i).Take(9);
            return View(viewsp);
        }

        public ActionResult quan_jean_nam()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "qjnam" select i).Take(9);
            return View(viewsp);
        }

        public ActionResult quan_kaki_nam()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "qkknam" select i).Take(9);
            return View(viewsp);
        }

        // do nu
        public ActionResult do_nu()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "asmnu" select i).Take(9);
            return View(viewsp);
        }
        public ActionResult so_mi_nu()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "asmnu" select i).Take(9);
            return View(viewsp);
        }
        public ActionResult ao_thun_nu()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "atnu" select i).Take(9);
            return View(viewsp);
        }
        public ActionResult quan_jean_nu()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "qjnu" select i).Take(9);
            return View(viewsp);
        }
        public ActionResult quan_short_nu()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "qsnu" select i).Take(9);
            return View(viewsp);
        }

        // ba lo tui xach
        public ActionResult balo_tuixach()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "bl_tx" select i).Take(9);
            return View(viewsp);
        }

        // giay
        public ActionResult giay()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "gnam" select i).Take(9);
            return View(viewsp);
        }

        public ActionResult giay_nam()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "gnam" select i).Take(9);
            return View(viewsp);
        }

        public ActionResult giay_nu()
        {
            db = new QLQUANAOEntities();
            List<Sanpham> splist = db.Sanphams.ToList();
            var viewsp = (from i in splist where i.loaisp == "gnu" select i).Take(9);
            return View(viewsp);
        }

        public ActionResult other_products()
        {
           
            return View();
        }
    }
}