using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.UnitTest
{
    [TestClass]
    public class SSNUnitTest
    {
        [TestMethod]
        public void Check_ValidNumber_ShouldBeTrue()
        {
            var number = "3285171076";
            Assert.IsTrue(PatientExtensions.CheckSSN(number));
        }

        [TestMethod]
        public void Check_ValidNumber01_ShouldBeTrue()
        {
            var number = "3665110902";
            Assert.IsTrue(PatientExtensions.CheckSSN(number));
        }
    }
}
