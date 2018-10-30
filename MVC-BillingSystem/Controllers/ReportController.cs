using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BillingSystem.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult GenerateBill()
        {
            return View();
        }

        public ActionResult GenerateSalesReport()
        {
            return View();
        }

        public ActionResult GenerateEmpReport()
        {
            return View();
        }
    }
}