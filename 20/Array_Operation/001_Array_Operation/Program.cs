using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Array_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой:
            1.получите от пользователя целое число. 
2.Создайте массив целочисленных элементов, длинной с полученное число.
3.С помощью цикла и обращаясь за значениями к пользователю заполните массив
целочисленных элементов.
4.Отсортируйте массив по убыванию, после чего измените размер массива на +1
элемент.
5.Обратитесь к пользователю и заполните новый элемент массива значением от
пользователя */


            Console.Write("Enter number: ");
            int lengthOfArray = int.Parse(Console.ReadLine());

            int[] usersArray = new int[lengthOfArray];
                       

            for (int counter = 0; counter < usersArray.Length; counter++)
            {
                Console.Write("Enter your number: ");
                usersArray[counter] = int.Parse(Console.ReadLine());
            }

            Array.Sort(usersArray);
            Console.WriteLine($"Your array: ");
            int index = 0;
            while (index < usersArray.Length)
            {
                Console.Write($"{usersArray[index]} ");
                index++;
            }
            Console.WriteLine();

            Console.WriteLine($"Your revers array: ");
            Array.Reverse(usersArray);
            int index2 = 0;

            while (index2 < usersArray.Length)
            {
                Console.Write($"{usersArray[index2]} ");
                index2++;
            }
            
            Console.ReadLine();                      
        }
    }
}
