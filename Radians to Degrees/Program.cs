using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която чете ъгъл в радиани (rad) и го преобразува в градуси (deg). 
             * Използвайте формулата: градус = радиан * 180 / π.
             * Числото π в Java програми е достъпно чрез Math.PI. 
             * Закръглете резултата до най-близкото цяло число използвайки "%.0f". */

            double rad = double.Parse(Console.ReadLine());

            double deg = rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(deg, 0));

        }
    }
}
