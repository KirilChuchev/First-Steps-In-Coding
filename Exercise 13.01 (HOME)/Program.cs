using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13._01__HOME_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма за конвертиране на щатски долари(USD) в български лева(BGN).
                Закръглете резултата до 2 цифри след десетичната запетая. 
                Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN. */

            double USD = double.Parse(Console.ReadLine());

            double BGN = USD * 1.79549;

            Console.WriteLine("{0}", Math.Round(BGN, 2));
        }
    }
}
