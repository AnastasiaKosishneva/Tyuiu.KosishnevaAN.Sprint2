using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint2.Task6.V10.Lib;

namespace Tyuiu.KosishnevaAN.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("4.10.2023", ds.FindDateOfPreviousDay(2023,10,5));
        }
    }
}
