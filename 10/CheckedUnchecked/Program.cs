using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUnchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, в которой в теле метода Main создайте две локальные
                переменные типа int в которые получите числа от пользователя и проинициализируйте 
                ее значением, полученным из консоли.
                Cоздайте блок, в котором, проверяя арифметические переполнения, выполните 
                умножение и сложение введенных чисел. Результат умножения и сложения выведите на 
                экран. Попробуйте вычисления с числами, явно вызывающими переполнение*/
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

           unchecked
            {
                int multiplication, additional;
                {
                   
                    multiplication = value1 * value2;
                    additional = value2 + value1;
                }
                    Console.WriteLine($"Result of multiplication: {multiplication}");
                    Console.WriteLine($"Result of additional: {additional}");
                    Console.ReadKey();
            }
        }
    }
}
