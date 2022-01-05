using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4._01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double aMAX;
            double bMAX;
            if (a < b)
            {
                aMAX = b - a;
                Console.WriteLine(aMAX);
            }
            else
            {
                bMAX = a - b;
                Console.WriteLine(bMAX);
            }

        }
    }
}
