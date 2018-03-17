using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OHMValueCalculator.Models;
using OhmValueCalculator.Classes;

namespace OHMValueCalculator.Controllers
{
    public class OHMCalculatorController : Controller
    {
        // GET: OHMCalculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateOhmValue()
        {
            OHMCalculatorModel model = new OHMCalculatorModel();
            OhmValueCalculatorHelperClass helperClass = new OhmValueCalculatorHelperClass();

            model.bandA = helperClass.CalculateBandValues("A");
            model.bandB = helperClass.CalculateBandValues("B");
            model.bandC = helperClass.CalculateBandValues("C");
            model.bandD = helperClass.CalculateBandValues("D");

            return View(model);
        }

    }
}