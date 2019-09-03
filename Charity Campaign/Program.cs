using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            /* В сладкарница се провежда благотворителна кампания за събиране на средства, 
             * в която могат да се включат сладкари от цялата страна. Първоначално прочитаме от конзолата броя на дните, 
             * в които тече кампанията и броя на сладкарите, които ще се включат. След това на отделни редове получаваме 
             * количеството на тортите, гофретите и палачинките, които ще бъдат приготвени от един сладкар за един ден. 
             * Трябва да се има предвид следния ценоразпис:
                •   Торта - 45 лв.
                •	Гофрета - 5.80 лв.
                •	Палачинка – 3.20 лв.
           
            1/8 от крайната сума ще бъде използвана за покриване на разходите за продуктите по време на кампанията. 
            Да се напише програма, която изчислява сумата, която е събрана в края на кампанията.
            
            Вход
            От конзолата се четат 5 реда:
            1.	Броят на дните, в които тече кампанията – цяло число в интервала [0 … 365]
            2.	Броят на сладкарите – цяло число в интервала [0 … 1000]
            3.	Броят на тортите – цяло число в интервала [0… 2000]
            4.	Броят на гофретите – цяло число в интервала [0 … 2000]
            5.	Броят на палачинките – цяло число в интервала [0 … 2000]
            Изход
            Да се отпечата на конзолата едно число:
            •	парите, които са събрани, форматирани до втория знак след десетичната запетая. */

            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesMoney = cakes * 45.00;
            double wafersMoney = wafers * 5.80;
            double pancakesMoney = pancakes * 3.20;

            double totalMoney = days * confectioners * (cakesMoney + wafersMoney + pancakesMoney);

            Console.WriteLine($"{(totalMoney * 7 / 8):F2}");


        }
    }
}
