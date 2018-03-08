using Shop_ThoiTrang_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult V()
        {
            QLQUANAOEntities db = new QLQUANAOEntities();
            List<Sanpham> sp = db.Sanphams.ToList();
            var showdata = (from i in sp where i.tinhtrang == "mới" select i).Take(3);
            return View(showdata);
        }

        public ActionResult a() {
            QLQUANAOEntities db = new QLQUANAOEntities();
            List<Sanpham> sp = db.Sanphams.ToList();
            var showdata = (from i in sp where i.soluong < 10 select i).Take(3);
            return View(showdata);
            
        }
    }
}