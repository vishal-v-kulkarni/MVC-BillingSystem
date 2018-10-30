using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BillingSystem.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult DoSales()
        {
            return View();
        }

        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }
    }
}