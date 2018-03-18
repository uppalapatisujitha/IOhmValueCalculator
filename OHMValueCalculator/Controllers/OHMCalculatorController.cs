using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OHMValueCalculator.Models;
using OhmValueCalculator.Classes;
using System.Threading.Tasks;

namespace OHMValueCalculator.Controllers
{
    public class OHMCalculatorController : Controller
    {
        OhmValueCalculatorHelperClass helperClass;
        OHMCalculatorModel model;

        public OHMCalculatorController()
        {
             helperClass  = new OhmValueCalculatorHelperClass();
             model = new OHMCalculatorModel();
          
           
            model.bandA = helperClass.CalculateBandValues("A");
            model.bandB = helperClass.CalculateBandValues("B");
            model.bandC = helperClass.CalculateBandValues("C");
            model.bandD = helperClass.CalculateBandValues("D");
        }
        // GET: OHMCalculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateOhmValue()
        {

            return View(model);
        }

        [HttpPost]
        public ActionResult CalculateOhmValue(OHMCalculatorModel formModel)
        {

                model.calculatedOhmValue = helperClass.CalculateOhmValue(formModel.bandASelectedValue, formModel.bandBSelectedValue, formModel.bandCSelectedValue, formModel.bandDSelectedValue);
            
            return View(model);
        }
    }
}