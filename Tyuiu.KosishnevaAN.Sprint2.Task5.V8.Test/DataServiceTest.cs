using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint2.Task5.V8.Lib;


namespace Tyuiu.KosishnevaAN.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1.2", ds.FindDateOfPreviousDay(2,2));
            Assert.AreEqual("31.12", ds.FindDateOfPreviousDay(1, 1));
            Assert.AreEqual("4.10", ds.FindDateOfPreviousDay(10, 5));

        }
    }
}
