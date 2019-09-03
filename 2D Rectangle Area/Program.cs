using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Правоъгълник е зададен с координатите на два от своите срещуположни ъгъла (x1, y1) – (x2, y2). 
             * Да се пресметнат площта и периметъра му. Входът се чете от конзолата. 
             * Числата x1, y1, x2 и y2 са дадени по едно наред. 
             * Изходът се извежда на конзолата и трябва да съдържа два реда с по една число на всеки от тях – лицето и периметъра. */

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x2 - x1);
            double width = Math.Abs(y2 - y1);

            double area = length * width;
            double perimeter = (length + width) * 2;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
