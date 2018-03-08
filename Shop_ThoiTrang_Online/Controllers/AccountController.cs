using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult forgotpassword()
        {

            return View();

        }

        public ActionResult changepassword()
        {

            return View();
        }

        public ActionResult pageuser()
        {
            return View();
        }

        public ActionResult changeinforcharacter() {
            return View();
        }

        public ActionResult Order()
        {

            return View();
        }
    }
}