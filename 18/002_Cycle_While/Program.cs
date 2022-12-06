using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Cycle_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой получите от пользователя два целых числа.
Используя цикл выведите все нечетные числа, расположенные между введенными
числами. */
            Console.WriteLine("Enter two numbers: ");

            int
                a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine());

            while (a <= b)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine(a);
                }
                a++;
             }
            while (a >= b)
            {
                if ((a % 2) != 0)
                {
                    Console.WriteLine(a);
                }
                a--;
            }

        }
    }
}
