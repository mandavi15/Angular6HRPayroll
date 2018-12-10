using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular6HRPayroll.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Company()
        {
            return View();
        }
        public ActionResult Department()
        {
            return View();
        }
        public ActionResult Designation()
        {
            return View();
        }
    }
}