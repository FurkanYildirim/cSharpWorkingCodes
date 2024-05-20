using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWorkingCodes
{
    internal class ClassesAndObjects
    {
        public void Run()
        {
            Console.WriteLine("Sınıflar ve Nesneler:");

            Person person1 = new Person("Ali", 25);
            person1.DisplayPersonInfo();

            Person person2 = new Person("Veli", 30);
            person2.DisplayPersonInfo();
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"İsim: {Name}, Yaş: {Age}");
        }
    }
}
