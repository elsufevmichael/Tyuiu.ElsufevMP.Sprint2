using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(True, False, True, False, True, False),
//при a = 247, b = 654, c = 671, d = 671

namespace Tyuiu.ElsufevMP.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (c == d); //true
            res[1] = (a > b) & (c > d); //false
            res[2] = (a < b) || (c <= d); //true
            res[3] = (a > b) && (c > d); //false
            res[4] = !(res[1]); //true
            res[5] = (a > b) ^ (c > d); //false

            return res;
        }
    }
}
