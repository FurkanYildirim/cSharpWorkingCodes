using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class FunctionsAndMethods
    {
        public void Run()
        {
            Console.WriteLine("Fonksiyonlar ve Metodlar:");

            Console.Write("Adınızı girin: ");
            string name = Console.ReadLine();

            GreetUser(name);
        }

        private void GreetUser(string userName)
        {
            Console.WriteLine($"Merhaba, {userName}!");
        }
    }
}
