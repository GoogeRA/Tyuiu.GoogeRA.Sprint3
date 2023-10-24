﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint3.Task5.V25.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах   *");
            Console.WriteLine("* Задание #4                                                 *");
            Console.WriteLine("* Вариант #13                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,           *");
            Console.WriteLine("* вычислить значение функции y=sin(x)/cos(x)                 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Старт шага первой суммы " + startValue1);
            Console.WriteLine("Конец шага первой суммы " + stopValue1);
            Console.WriteLine("Старт шага втрой суммы " + startValue2);
            Console.WriteLine("Конец шага втрой суммы " + stopValue2);


            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Сумма сумм ряда = " + ds.GetSumSumSeries(x,startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
