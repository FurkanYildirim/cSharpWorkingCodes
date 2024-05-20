using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cSharpWorkingCodes
{
    internal class FileReadWrite
    {
        public void Run()
        {
            Console.WriteLine("Dosya Okuma ve Yazma:");

            string filePath = "example.txt";

            // Dosyaya yazma
            Console.Write("Dosyaya yazmak için bir metin girin: ");
            string textToWrite = Console.ReadLine();
            File.WriteAllText(filePath, textToWrite);
            Console.WriteLine($"'{filePath}' dosyasına yazıldı.");

            // Dosyadan okuma
            string readText = File.ReadAllText(filePath);
            Console.WriteLine($"'{filePath}' dosyasından okunan metin: {readText}");

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
