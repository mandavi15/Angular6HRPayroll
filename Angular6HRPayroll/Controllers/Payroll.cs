using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular6HRPayroll.Controllers
{
    public class PayrollController : Controller
    {
        // GET: Payroll
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PayCycle()
        {
            return View();
        }
    }
}