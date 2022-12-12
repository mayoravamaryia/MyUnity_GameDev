using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой воспользуйтесь массивом строк из предыдущего задания. 
Создайте цикл, в котором обратитесь к пользователю. Пользователь для первой 
итерации цикла должен ввести строковое значение первого по порядку месяца, для 
второй итерации – строковое значение второго месяца и так далее до конца массива. 
Если пользователь введет неправильно текущее значение месяца – итерация цикла 
должна повториться с тем, чтобы пользователь попробовал ввести значение еще 
раз. Если пользователь ошибется при вводе значения 5го месяца – цикл должен 
прекратить свою работу */


            string[] monthList = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.Write("Enter ordinal first month: ");

            string userMonth = Console.ReadLine();

            int counter = 0;

            while (counter < monthList.Length)
            {
                if (counter == 4 && userMonth != monthList[4])
                {
                    Console.WriteLine("Finsh!");
                    break;
                }
                else if (userMonth == monthList[counter])
                {
                    counter++;
                    Console.Write("Enter next month: ");
                    userMonth = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter true month!");
                    Console.Write("Enter next month: ");
                    userMonth = Console.ReadLine();
                }
            }
        }
    }
}

