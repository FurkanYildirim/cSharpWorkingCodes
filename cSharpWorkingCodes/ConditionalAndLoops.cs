using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class ConditionalAndLoops
    {
        public void Run()
        {
            Console.WriteLine("Koşullu İfadeler ve Döngüler:");

            Console.Write("Bir sayı girin: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çift.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tek.");
            }

            Console.WriteLine("1'den 10'a kadar sayılar:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
