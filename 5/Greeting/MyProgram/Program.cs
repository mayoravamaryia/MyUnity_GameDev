using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What is your surname: ");
            string surname = Console.ReadLine();

            string greeting1 = "Hello, " + name + " " + surname + "! " + "It's a good day today!\n";

            Console.Write(greeting1); // Использование конкотенации

            string greeting2 = $"Hello, {name} {surname}! It's a good day today!\n";
            Console.Write(greeting2);


            Console.ReadKey();
        }
    }
}
