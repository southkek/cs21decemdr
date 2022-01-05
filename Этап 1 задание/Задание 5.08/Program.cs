using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double redA = Convert.ToDouble(Console.ReadLine());
            double redB = Convert.ToDouble(Console.ReadLine());
            double greenA = Convert.ToDouble(Console.ReadLine());
            double greenB = Convert.ToDouble(Console.ReadLine());

            if ((greenA < redB) && (greenB > redB))
            {
                Console.WriteLine("Интервалы пересекаются");
                return;
            }
            if ((greenA < redA) && (redA < greenB))
            {
                Console.WriteLine("Интервалы пересекаются");
                return;
            }
            if (redB < greenA)
            {
                Console.WriteLine("Интервалы не пересекаются. Правый край красного левее левого края зеленого.");
                return;
            }
            if (redA > greenB)
            {
                Console.WriteLine("Интервалы не пересекаются. Правый край зеленого левее левого края красного");
                return;
            }
            if ((redA > redB) || (greenA >greenB))
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
                return;
            }
        }
    }
}
