using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint3.Task2.V25.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Оператор цикла do-while                              *");
            Console.WriteLine("* Задание #2                                                 *");
            Console.WriteLine("* Вариант #25                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу используя цикл do while                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле при x = 0.5 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int value = 5;
            int starValue = 1;
            int stopValue = 13;

            Console.WriteLine("Переменная X " + value);
            Console.WriteLine("Старт шага " + starValue);
            Console.WriteLine("Конец шага " + stopValue);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Произведение ряда = " + ds.GetSumSeries(value, starValue, stopValue));
            Console.ReadKey();
        }
    }
}
