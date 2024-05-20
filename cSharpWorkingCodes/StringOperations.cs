using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class StringOperations
    {
        public void Run()
        {
            Console.WriteLine("String İşlemleri:");

            Console.Write("Bir metin girin: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Büyük Harf: {input.ToUpper()}");
            Console.WriteLine($"Küçük Harf: {input.ToLower()}");
            Console.WriteLine($"Karakter Sayısı: {input.Length}");

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
