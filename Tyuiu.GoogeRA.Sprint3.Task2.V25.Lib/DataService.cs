﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GoogeRA.Sprint3.Task2.V25.Lib
{
    public class DataService : ISprint3Task2V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                sumSeries = sumSeries + Math.Pow(4 / Math.Pow(startValue, value), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
