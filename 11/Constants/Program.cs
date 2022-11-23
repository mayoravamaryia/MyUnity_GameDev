using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой в теле метода Main создайте две константы - с именем PI,
которой присвойте значение 3,141593, и с именем MY_CONST, которой присвойте значение 
true.
Выполните сравнение того значения, которое ввел пользователь, с тем значением, которое 
хранится в константе PI и сохраните результат сравнения в переменную с именем 
iSConstBigger. Далее, проверьте на равенство значение переменной iSConstBigger со 
значением MY_CONST. Результат последнего сравнения выведите на экран консоли */
            
            const double PI = 3.141593;
            const bool MY_CONST = true;

            Console.Write("Enter your value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            bool iSConstBigger = PI >= value;
            bool evaluated = MY_CONST == iSConstBigger;

            Console.WriteLine($"Results of evaluated is: {evaluated}");
            Console.ReadKey();
        }
    }
}
