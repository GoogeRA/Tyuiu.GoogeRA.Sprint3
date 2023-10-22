using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint3.Task3.V12.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "bkkrk ckkkcs ksr";
            char chr = 'k';

            int res = ds.GetMaxCharCount(str, chr);
            int wait = 7;

            Assert.AreEqual(wait, res);


        }
    }
}
