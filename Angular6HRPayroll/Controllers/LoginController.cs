using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular6HRPayroll.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page";

            return View();
        }
        public ActionResult Login2()
        {
            ViewBag.Message = "Your Login page";

            return View();
        }
    }
}