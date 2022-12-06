using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Cycle_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой получите целое число и используя циклическую
конструкцию выведите на экран консоли все числа от введенного и до нуля
включительно */

            Console.WriteLine("Enter numbers: ");

            int a = Convert.ToInt32(Console.ReadLine());

            while (a > 0)
            {
                Console.WriteLine(a--);
            }
            Console.WriteLine(a);

        }
    }
}
