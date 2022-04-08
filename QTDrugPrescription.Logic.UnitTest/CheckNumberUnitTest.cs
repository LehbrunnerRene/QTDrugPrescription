using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.UnitTest
{
    [TestClass]
    public class CheckNumberUnitTest
    {
        [TestMethod]
        public void Check_ValidNumberWithoutX_ShouldBeTrue()
        {
            var number = "0747551006";
            Assert.IsTrue(DrugExtensions.CheckNumber(number));
        }
        [TestMethod]
        public void Check_ValidNumberWithX_ShouldBeTrue()
        {
            var number = "349913599X";
            Assert.IsTrue(DrugExtensions.CheckNumber(number));
        }
    }
}
