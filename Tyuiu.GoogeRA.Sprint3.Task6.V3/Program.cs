using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint3.Task6.V3.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                   *");
            Console.WriteLine("* Задание #6                                                 *");
            Console.WriteLine("* Вариант #3                                                 *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,        *");
            Console.WriteLine("* принадлежащих числовому отрезку [13, 19]                   *");
            Console.WriteLine("* сумму всех делителей больше 8                             * ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

           
            int startValue = 13;
            int stopValue = 19;

            Console.WriteLine("Начало отрезка " + startValue);
            Console.WriteLine("Конец отрезка " + stopValue);
          


            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Сумма сумм ряда = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
