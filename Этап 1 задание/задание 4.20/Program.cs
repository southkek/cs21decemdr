using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Xt = Convert.ToDouble(Console.ReadLine());
            double Yt = Convert.ToDouble(Console.ReadLine());
            double Xп1 = Convert.ToDouble(Console.ReadLine());
            double Yп1 = Convert.ToDouble(Console.ReadLine());
            double Xп2 = Convert.ToDouble(Console.ReadLine());
            double Yп2 = Convert.ToDouble(Console.ReadLine());
            double totX;
            double totY;
            //решение
            if (Xt < 0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }
            totX = (Xt - Xп1) / (Xп2 - Xп1);
            totY = (Yt - Yп1) / (Yп2 - Yп1);
            if (totX == totY)
            {
                Console.WriteLine("Точка принадлежит прямой");
                return;
            }
            else
            {
                Console.WriteLine("Точка не принадлежит прямой");
                return;
            }
            


        }
    }
}
