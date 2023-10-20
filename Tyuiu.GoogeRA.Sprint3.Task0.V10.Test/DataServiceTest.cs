using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint3.Task0.V10.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int starValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, starValue, stopValue);

            double wait = 0.033;

            Assert.AreEqual(wait, res);
        }
    }
}
