using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class ArraysAndLists
    {
        public void Run()
        {
            Console.WriteLine("Diziler ve Listeler:");

            int[] numbersArray = { 1, 2, 3, 4, 5 };
            List<string> namesList = new List<string> { "Ahmet", "Mehmet", "Ayşe" };

            Console.WriteLine("Dizideki sayılar:");
            foreach (int number in numbersArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Listedeki isimler:");
            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
