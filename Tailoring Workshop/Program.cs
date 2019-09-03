using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Шивашки цех приема поръчки за ушиване на покривки и карета за маси за заведения. 
             * Покривките са правоъгълни, каретата са квадратни, броят им винаги е еднакъв.
             * Покривката трябва да виси с 30 см от всеки ръб на масата. 
             * Страната на каретата е половината от дължината на масите.
             * Във всяка поръчка се включва информация за броя и размерите на масите.
             * Напишете програма, която пресмята цената на поръчка в долари и в левове, като квадратен метър плат 
             * за правоъгълна покривка струва 7 долара, а за каре – 9 долара.Курсът на долара е 1.85 лева. */

            int number = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double areaCover = (length + 0.6) * (width + 0.6);
            double areaSquare = Math.Pow((length) / 2, 2);

            double priceUsd = number * ((areaCover * 7) + (areaSquare * 9));
            double priceBgn = priceUsd * 1.85;

            Console.WriteLine($"{priceUsd:F2} USD");
            Console.WriteLine($"{priceBgn:F2} BGN");
        }
    }
}
