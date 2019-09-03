using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Пешо решава да направи купон и отива до алкохолната борса за да купи бира, вино, ракия и уиски. 
             * На конзолата се въвежда цената на уискито в лв./л. и количеството на бирата, виното, ракията и уискито, 
             * които трябва да закупи. Да се напише програма, която пресмята колко пари са му необходими за да плати сметката, 
             * като знаете, че:
                •	цената на ракията е на половина по-ниска от тази на уискито;
                •	цената на виното е с 40% по-ниска от цената на ракията;
                •	цената на бирата е с 80% по-ниска от цената на ракията.
                
            Вход
                От конзолата се четат 5 реда:
                1.	Цена на уискито в лева – реално число в интервала [0.00 … 10000.00]
                2.	Количество на бирата в литри – реално число в интервала [0.00 … 10000.00]
                3.	Количество на виното в литри – реално число в интервала [0.00 … 10000.00]
                4.	Количество на ракията в литри – реално число в интервала [0.00 … 10000.00]
                5.	Количество на уискито в литри – реално число в интервала [0.00 … 10000.00]
               
            Изход
                Да се отпечата на конзолата едно число:
                •	парите, които са необходими на Пешо, форматирани до втория знак след десетичната запетая.
                 */

            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiyaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiyaPrice = whiskeyPrice / 2.00;
            double winePrice = rakiyaPrice - (0.40 * rakiyaPrice);
            double beerPrice = rakiyaPrice - (0.80 * rakiyaPrice);

            double sum = (whiskeyPrice * whiskeyQuantity) + (beerPrice * beerQuantity) + (winePrice * wineQuantity) + (rakiyaPrice * rakiyaQuantity);

            Console.WriteLine("{0:F2}", sum);
            

        }
    }
}
