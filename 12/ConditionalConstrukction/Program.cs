using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalConstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой в теле метода Main примите от пользователя число.
 С помощью конструкции if-else реализуйте алгоритм ветвления, в котором:
 Если число больше 3 – нужно увеличить значение переменной, хранящей число, на
 10.Иначе – увеличить эту переменную в 10 раз.Вывести значение переменной */

            Console.Write("Enter your number: ");
            string value = Console.ReadLine();
            int convertValue = Convert.ToInt32(value);

            const int EVALUTED_PARAMETR = 3;
            bool evaluatedValue = convertValue > EVALUTED_PARAMETR;

            int result;
            int result1;
            if (evaluatedValue)
            {
                result = convertValue + 10;
                Console.WriteLine(result);
            }
            else
            {
                result1 = convertValue * 10;
                Console.WriteLine(result1);
            }
        }
    }
}
