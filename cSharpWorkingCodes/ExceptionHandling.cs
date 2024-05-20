using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class ExceptionHandling
    {
        public void Run()
        {
            Console.WriteLine("İstisna Yönetimi:");

            try
            {
                Console.Write("Bir sayı girin: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girdiğiniz sayı: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmedik bir hata oluştu: {ex.Message}");
            }
        }
    }
}
