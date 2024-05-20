using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Çalıştırmak istediğiniz örneği seçin:");
                Console.WriteLine("1. Basit Matematiksel İşlemler");
                Console.WriteLine("2. Koşullu İfadeler ve Döngüler");
                Console.WriteLine("3. Fonksiyonlar ve Metodlar");
                Console.WriteLine("4. Diziler ve Listeler");
                Console.WriteLine("5. Sınıflar ve Nesneler");
                Console.WriteLine("6. İstisna Yönetimi");
                Console.WriteLine("7. String İşlemleri");
                Console.WriteLine("8. Tarih ve Zaman İşlemleri");
                Console.WriteLine("9. Dosya Okuma ve Yazma");
                Console.WriteLine("10. LINQ Sorguları");
                Console.WriteLine("0. Çıkış");

                Console.Write("Seçiminizi girin: ");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 10)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen 0 ile 10 arasında bir sayı girin.");
                    Console.Write("Seçiminizi girin: ");
                }

                if (choice == 0)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        var basicMath = new BasicMathOperations();
                        basicMath.Run();
                        break;
                    case 2:
                        var conditionalLoops = new ConditionalAndLoops();
                        conditionalLoops.Run();
                        break;
                    case 3:
                        var functionsMethods = new FunctionsAndMethods();
                        functionsMethods.Run();
                        break;
                    case 4:
                        var arraysLists = new ArraysAndLists();
                        arraysLists.Run();
                        break;
                    case 5:
                        var classesObjects = new ClassesAndObjects();
                        classesObjects.Run();
                        break;
                    case 6:
                        var exceptionHandling = new ExceptionHandling();
                        exceptionHandling.Run();
                        break;
                    case 7:
                        var stringOperations = new StringOperations();
                        stringOperations.Run();
                        break;
                    case 8:
                        var dateAndTimeOperations = new DateAndTimeOperations();
                        dateAndTimeOperations.Run();
                        break;
                    case 9:
                        var fileReadWrite = new FileReadWrite();
                        fileReadWrite.Run();
                        break;
                    case 10:
                        var linqQueries = new LINQQueries();
                        linqQueries.Run();
                        break;
                }

                Console.WriteLine("Bir başka örnek çalıştırmak için Enter tuşuna basın...");
                Console.ReadLine();
            }
        }
    }
}