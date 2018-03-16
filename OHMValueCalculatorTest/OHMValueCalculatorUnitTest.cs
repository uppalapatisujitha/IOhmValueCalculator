using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;


namespace OHMValueCalculatorTest
{
    [TestFixture]
    public class OHMValueCalculatorUnitTest
    {
        //Test case 1 to check if result obtained when all bands values are selected 
        [Test]
        public void checkForValuesGivenInAllBandsTest1()
        {
            OhmValueCalculator.Classes.OhmValueCalculator calculator = new OhmValueCalculator.Classes.OhmValueCalculator();
            var res = calculator.CalculateOhmValue("Orange", "Brown", "Black", "Red");
            Assert.AreEqual(res,31);

        }

        //Test case 2 to check if result obtained when all bands values are selected
        [Test]
        public void checkForValuesGivenInAllBandsTest2()
        {
            OhmValueCalculator.Classes.OhmValueCalculator calculator = new OhmValueCalculator.Classes.OhmValueCalculator();
            var res = calculator.CalculateOhmValue("Green", "Yellow", "Gold", "Red");
            Assert.AreEqual(res, 5.4);

        }

        //Test case to check result when tolerance band value is None
        [Test]
        public void checkForToleranceBandNone()
        {
            OhmValueCalculator.Classes.OhmValueCalculator calculator = new OhmValueCalculator.Classes.OhmValueCalculator();
            var res = calculator.CalculateOhmValue("Green", "Yellow", "Gold", "None");
            Assert.AreEqual(res, 79);

        }

        //Test case if result is null
        [Test]
        public void checkForIsNullTest()
        {
            OhmValueCalculator.Classes.OhmValueCalculator calculator = new OhmValueCalculator.Classes.OhmValueCalculator();
            var res = calculator.CalculateOhmValue("Red","Yellow","Green","Blue");
            Assert.IsNotNull(res);

        }

    }
}
