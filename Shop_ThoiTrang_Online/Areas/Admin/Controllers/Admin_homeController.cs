using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Areas.Admin.Controllers
{
    public class Admin_homeController : Controller
    {
        // GET: Admin/Home
        public ActionResult admin_index()
        {
            return View();
        }
    }
}