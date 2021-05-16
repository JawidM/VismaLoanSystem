using System;
using System.Web.Mvc;
using VismaLoanSystem.Models;

namespace VismaLoanSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HousingLoan model = new HousingLoan();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HousingLoan newHL)
        {
            if (ModelState.IsValid)
            {
                newHL.MonthlyPayback = Math.Round((newHL.DesiredAmount * 
                    (1 + (newHL.InterestRatePerYear * newHL.PaybackTime))) /
                    (newHL.PaybackTime * 12), 2);
            }
            return View(newHL);
        }

        public ActionResult CalculateAjax()
        {
            return View();
        }

        public ActionResult CalculateWithAjax(uint amount, uint year)
        {
            var result = Math.Round((amount * (1 + (0.035 * year))) / (year * 12), 2);
            var data = new { status = "ok", result = result };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact: ";

            return View();
        }
    }
}