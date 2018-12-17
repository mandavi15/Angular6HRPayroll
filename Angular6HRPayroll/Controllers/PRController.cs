using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular6HRPayroll.Controllers
{
    public class PRController : Controller
    {
        // GET: PR
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult setup()
        {
            return View();
        }
    }
}