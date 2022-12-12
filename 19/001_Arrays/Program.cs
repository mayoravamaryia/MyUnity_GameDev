using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой создайте массив строковых элементов.В блоке
инициализатора заполните массив названиями месяцев по порядку.Далее создайте
цикл, в котором выведите на экран консоли все содержимое массива строк. */

            string[] stringsArray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
           
            int index = 0;
                
            while (index <= 11)
            {
               string month = stringsArray[index];
               Console.WriteLine(month);
               index++;
            }


        }
    }
}
