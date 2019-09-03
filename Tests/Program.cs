using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
             double l = double.Parse(Console.ReadLine());
             double w = double.Parse(Console.ReadLine());

             double rows = Math.Floor(l / 1.20);
             double columns = Math.Floor((w - 1) / 0.70);
             double places = (rows * columns) - 3;
             Console.WriteLine(places);
             
        }
    }
}
