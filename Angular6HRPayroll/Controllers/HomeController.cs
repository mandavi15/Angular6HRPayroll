using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular6HRPayroll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult HRAreaPage()
        {
            ViewBag.Message = "Your HR Area page.";

            return View();
        }
        public ActionResult Location()
        {
           
            return View();
        }
        public ActionResult ItemMaster()
        {

            return View();
        }
        public ActionResult EmployeeDocMaster()
        {

            return View();
        }
        
    }

}