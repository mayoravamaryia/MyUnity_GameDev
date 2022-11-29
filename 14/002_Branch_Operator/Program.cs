using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Branch_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Пользователь вводит 4 числа. Найти наибольшее четное. Если такого нет – вывести 
«Not found». Если есть – вывести его. (Решите задачу с использованием условных 
конструкций) */
            Console.WriteLine("Enter 4 numbers: ");

            int value1, value2, value3, value4, maxEvenValue;
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = Convert.ToInt32(Console.ReadLine());
            value4 = Convert.ToInt32(Console.ReadLine());
            maxEvenValue = int.MinValue;

            if (value1 % 2 == 0)
            {
                maxEvenValue = value1;
            }
            if (value2 % 2 == 0 && value2 > maxEvenValue)
            {
                maxEvenValue = value2;
            }
            if (value3 % 2 == 0 && value3 > maxEvenValue)
            {
                maxEvenValue = value3;
            }
            if (value4 % 2 == 0 && value4 > maxEvenValue)
            {
                maxEvenValue = value4;
                
            }
            if (maxEvenValue != int.MinValue)
            {
                Console.WriteLine($"Max even number is {maxEvenValue}");
            }

            else
            {
                Console.WriteLine("Not found");
            }



            Console.ReadKey();
        }
    }
}
