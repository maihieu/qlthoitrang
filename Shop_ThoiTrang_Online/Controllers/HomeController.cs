using Shop_ThoiTrang_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class HomeController : Controller
    {
        QLQUANAOEntities db;
        public ActionResult Index()
        {
            // lay do nam
            db = new QLQUANAOEntities();
            List<Sanpham> spList = db.Sanphams.ToList();
            var sp_banchay = (from i in spList where i.soluong<10 select i).Take(9);
            ViewBag.sp_banchay = sp_banchay;

            var sp_moi = (from spmoi in spList where spmoi.tinhtrang == "mới" select spmoi).Take(3);
            ViewBag.spmoi = sp_moi;
            return View();
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}