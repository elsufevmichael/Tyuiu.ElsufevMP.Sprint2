using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElsufevMP.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            switch (value)
            {
                case 1: return "Пики";
                case 2: return "Трефы";
                case 3: return "Бубны";
                case 4: return "Червы";
                default: throw new ArgumentException($"Значение должно быть от 1 до 4. Введено {value}"); ;
            }
        }
    }
}
