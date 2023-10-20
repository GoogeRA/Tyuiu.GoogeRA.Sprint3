using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint3.Task0.V10.Lib;


namespace Tyuiu.GoogeRA.Sprint3.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                           *");
            Console.WriteLine("* Задание #0                                                 *");
            Console.WriteLine("* Вариант #10                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет   *");
            Console.WriteLine("* произведение ряда по формуле, при x = 5                    *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            int value =5;
            int starValue = 1;
            int stopValue = 5;

            Console.WriteLine("Переменная X" + value);
            Console.WriteLine("Старт шага" + starValue);
            Console.WriteLine("Конец шага" + stopValue);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Произведение ряда = "  + ds.GetMultiplySeries(value, starValue, stopValue));

            Console.ReadKey();

        }
    }
}
