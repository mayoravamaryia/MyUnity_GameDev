using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Задание 2 
Напишите программу, в которой получите от пользователя два целых числа в 
переменные x и y. Для каждого из полученных чисел, используя тернарный оператор, 
выполните проверку на то, является ли число четным, и если число является четным 
– оставьте его значение неизменным, а если число является нечетным – увеличьте 
его значение на 1.
Создайте строковую переменную result, в которую присвойте результат выполнения 
тернарного оператора. В этом тернарном операторе выполните проверку на то, 
делится ли сума чисел, полученная в первой части задачи, на 4 без остатка. Если 
сумма делится на 4 без остатка – переменной result присвойте фразу «Сумма 
значений {x} и {y} делится на 4» (используйте интерполяцию строк). Если сумма на 4 
не делится – присвойте фразу «Сумма значений {x} и {y} на 4 не делится». Выведите 
значение result на экран */


            Console.WriteLine("Enter your numbers: ");

            int a, b, c, x, y;
                        
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            a = x % 2;
            b = y % 2;

            x = (a == 0) ? x : ++x;
            y = (b == 0) ? y : ++y;

            c = (x + y) % 4;
            
            string result, value1, value2;

            value1 =$"Summa of values {x} and {y} devided by 4";
            value2 = $"Summa of values {x} and {y} not devided by 4";

            result = (c == 0) ? value1 : value2;

            Console.WriteLine(result);



        }
    }
}
