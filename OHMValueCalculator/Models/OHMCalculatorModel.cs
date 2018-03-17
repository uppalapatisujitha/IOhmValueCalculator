using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace OHMValueCalculator.Models
{
    public class OHMCalculatorModel
    {
        public List<SelectListItem> bandA;

        public List<SelectListItem> BandA
        {
            get { return bandA; }
            set { bandA = value; }
        }
        public List<SelectListItem> bandB;

        public List<SelectListItem> BandB
        {
            get { return bandB; }
            set { bandB = value; }
        }
        public List<SelectListItem> bandC;

        public List<SelectListItem> BandC
        {
            get { return bandC; }
            set { bandC = value; }
        }
        public List<SelectListItem> bandD;

        public List<SelectListItem> BandD
        {
            get { return bandD; }
            set { bandD = value; }
        }

        public string bandASelectedValue;

        public string BandASelectedValue
        {
            get { return bandASelectedValue; }
            set { bandASelectedValue = value; }
        }

        public string bandBSelectedValue;

        public string BandBSelectedValue
        {
            get { return bandBSelectedValue; }
            set { bandBSelectedValue = value; }
        }

        public string bandCSelectedValue;

        public string BandCSelectedValue
        {
            get { return bandCSelectedValue; }
            set { bandCSelectedValue = value; }
        }

        public string bandDSelectedValue;

        public string BandDSelectedValue
        {
            get { return bandDSelectedValue; }
            set { bandDSelectedValue = value; }
        }
        public int calculatedOhmValue;

        public int CalculatedOhmValue
        {
            get { return calculatedOhmValue; }
            set { calculatedOhmValue = value; }
        }
    
    }
}