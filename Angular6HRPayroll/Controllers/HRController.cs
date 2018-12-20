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
        public ActionResult Localization()
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
        public ActionResult Skills()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View();
        }
        public ActionResult Requisition()

        {
            return View();
        }
        public ActionResult CreatenewRequisition()

        {
            return View();
        }
        public ActionResult LeaveType()
        {
            ViewBag.Message = "Your LeaveType page.";

            return View();
        }
        public ActionResult LeaveEmployee()
        {
            ViewBag.Message = "Your LeaveType page.";

            return View();
        }
        public ActionResult ExitManagement()
        {
            return View();
        }
        public ActionResult ResignForm()
        {
            return View();
        }
        public ActionResult Commodities()
        {
            return View();
        }
        public ActionResult payslab()
        {
            return View();
        }
        public ActionResult paystructure()
        {
            return View();
        }
        public ActionResult ComplaintGrievance()
        {
            return View();
        }
        public ActionResult CreateComplaint()
        {
            return View();
        }
    }
}