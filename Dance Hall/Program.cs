using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Група танцьори си търсят нова зала.  Залата, която са харесали, е правоъгълна и има размери:
             * L - дължина и W - ширина (в метри). В залата има квадратен гардероб със страна - A и 
             * правоъгълна скамейка с площ 10 пъти по-малка от площта на залата. 
             * Мястото, което заема един танцьор е 40 см² и допълнително за свободно движение му трябват  още  7000см². 
             * Напишете програма, която да изчислява колко танцьори могат да се поберат в залата и да се движат свободно. 
             * Полученият резултат трябва да се закръгли до най-близкото цяло число надолу. */

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hall = L * W;
            double wardrobe = Math.Pow(A, 2);
            double bench = hall / 10;
            double dancer = (40.00 + 7000.00) / (100 * 100); 
            

            double freeArea = hall - wardrobe - bench;
            double dancerNum = freeArea / dancer;

            Console.WriteLine(Math.Floor(dancerNum));
            



        }
    }
}
