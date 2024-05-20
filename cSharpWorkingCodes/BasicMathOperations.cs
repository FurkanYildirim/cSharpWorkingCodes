using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class BasicMathOperations
    {
        public void Run()
        {
            Console.WriteLine("Basit Matematiksel İşlemler:");

            try
            {
                Console.Write("Birinci sayıyı girin: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Toplama: {num1 + num2}");
                Console.WriteLine($"Çıkarma: {num1 - num2}");
                Console.WriteLine($"Çarpma: {num1 * num2}");
                Console.WriteLine($"Bölme: {num1 / num2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
