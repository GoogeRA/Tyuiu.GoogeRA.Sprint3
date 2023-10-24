using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint3.Task7.V20.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService service1 = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] v;
            v = new double[len];

            v[0] = 17.23;
            v[1] = 14.03;
            v[2] = 10.21;
            v[3] = 6.58;
            v[4] = 3.77;
            v[5] = 0.00;
            v[6] = -0.54;
            v[7] = -3.61;
            v[8] = -7.51;
            v[9] = -11.49;
            v[10] = -14.69;

            double[] res;
            res = new double[len];
            res = service1.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(v, res);

        }
    }
}
