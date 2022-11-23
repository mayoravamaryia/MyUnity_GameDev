using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int strLen = inputString.Length;

            if (strLen == 5)
            {
                Console.WriteLine("Да, длина строки равна 5");
            }
            else
            {
                Console.WriteLine("Нет, длина строки не равна 5");
            }
        }
    }
}
