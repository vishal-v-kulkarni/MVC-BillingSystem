using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BillingSystem.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult ManageProducts()
        {
            return View();
        }

        public ActionResult ListProducts()
        {
            return View();
        }

        public ActionResult ListExpProducts()
        {
            return View();
        }

        public ActionResult UpdateInventory()
        {
            return View();
        }

        public ActionResult QueryInventory()
        {
            return View();
        }
    }
}