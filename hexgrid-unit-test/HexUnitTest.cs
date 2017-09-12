using System;
using hexgrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hexgrid_unit_test
{
    [TestClass]
    public class HexUnitTest
    {

        [TestMethod]
        public void Hex_CalculatesWidthCorrectly()
        {
            int pixelRadius = 34;
            Hex testHex = new Hex(pixelRadius);

            int reportedWidth = testHex.GetWidth();
            int correctWidth = 68;
            Assert.AreEqual(correctWidth, reportedWidth);
        }

        [TestMethod]
        public void GetCoordinatesUnitTest()
        {

        }
    }
}
