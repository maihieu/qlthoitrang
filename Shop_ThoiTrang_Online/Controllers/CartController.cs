using Shop_ThoiTrang_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ThoiTrang_Online.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        QLQUANAOEntities db = new QLQUANAOEntities();
        public ActionResult details_cart()
        {
            return View();
        }

        private int isExisting(int masp)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Sanpham.masp == masp)
                    return i;
            }

            return -1;
        }

        public ActionResult them_gio_hang(int masp) {

            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.Sanphams.Find(masp), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(masp);
                if (index == -1)
                {
                    cart.Add(new Item(db.Sanphams.Find(masp), 1));
                }
                else
                {
                    cart[index].Soluong++;
                }


                Session["cart"] = cart;
            }
            return View("details_cart");


        }

        public ActionResult xoa(int masp) {
            int i = isExisting(masp);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(i);
            Session["cart"] = cart;
            return RedirectToAction("details_cart","Cart");
        }
    }
}