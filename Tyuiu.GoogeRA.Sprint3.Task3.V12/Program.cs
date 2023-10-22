using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint3.Task3.V12.Lib;

namespace Tyuiu.GoogeRA.Sprint3.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Оператор цикла foreach                               *");
            Console.WriteLine("* Задание #3                                                 *");
            Console.WriteLine("* Вариант #12                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу используя цикл foreach  подсчитать      *");
            Console.WriteLine("* максимальное количество букв k в строке: bkkrk ckkkcs ksr  *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            string value = "bkkrk ckkkcs ksr";
            char chr = 'k';

            Console.WriteLine("Исходная строка " + value);
            Console.WriteLine("Исходный символ " + chr);
            

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Колличесто  символов = " + ds.GetMaxCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
