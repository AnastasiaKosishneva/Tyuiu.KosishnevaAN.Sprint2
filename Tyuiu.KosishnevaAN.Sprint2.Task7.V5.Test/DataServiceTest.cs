using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint2.Task7.V5.Lib;

namespace Tyuiu.KosishnevaAN.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.1;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
