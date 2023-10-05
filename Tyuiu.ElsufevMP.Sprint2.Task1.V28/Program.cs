using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElsufevMP.Sprint2.Task1.V28.Lib;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(True, False, True, False, True, False), при a = 247, b = 654, c = 671, d = 671

namespace Tyuiu.ElsufevMP.Sprint2.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            Console.Title = "Спринт #2 | Выполнил: Елсуфьев М. П. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Елсуфьев Михаил Павлович | ИИПб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* а также арифметических выражений, которая вернет массив                 *");
            Console.WriteLine("* (True, False, True, False, True, False)                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
