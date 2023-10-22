using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint3.Task2.V25.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 13;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wail = 16.016;
            Assert.AreEqual(wail, res);
        }
    }
}
