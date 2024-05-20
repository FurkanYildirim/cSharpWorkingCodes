using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace cSharpWorkingCodes
{
    internal class LINQQueries
    {
        public void Run()
        {
            Console.WriteLine("LINQ Sorguları:");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Çift sayılar:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            var squaredNumbers = numbers.Select(n => n * n);
            Console.WriteLine("Kareleri:");
            foreach (var num in squaredNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
