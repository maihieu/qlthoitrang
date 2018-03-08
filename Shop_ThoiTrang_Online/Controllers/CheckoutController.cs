using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult payment()
        {
            return View();
        }
    }
}