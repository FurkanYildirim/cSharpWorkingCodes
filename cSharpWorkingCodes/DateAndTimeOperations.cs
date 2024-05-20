using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class DateAndTimeOperations
    {
        public void Run()
        {
            Console.WriteLine("Tarih ve Zaman İşlemleri:");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Şu anki tarih ve zaman: {now}");
            Console.WriteLine($"Gün: {now.Day}, Ay: {now.Month}, Yıl: {now.Year}");
            Console.WriteLine($"Saat: {now.Hour}, Dakika: {now.Minute}, Saniye: {now.Second}");

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
