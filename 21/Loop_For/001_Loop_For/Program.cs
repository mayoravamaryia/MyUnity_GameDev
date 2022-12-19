using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Loop_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой, используя конструкции цикла со счетчиком:
1. Выведите на экран консоли все числа от 0 до 100;
2. Выведите на экран числа от 1001 до 2500 с шагом – 3;
3. Выведите числа от 100 до 0 с шагом – 4;
4. Выведите числа от 1 до 5 с шагом 0,2.
 */
            int length = 100;
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine(i);
            }

            length = 2500;

            for (int i = 1001; i <= length; i +=3 )
            {
                Console.WriteLine(i);
            }

            length = 0;
            for (int i = 100; i >= length; i -=4)
            {
                Console.WriteLine(i);
            }

            float length1 = 5.0f;
            for (float i = 1; i <= length1; i += 0.2f)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}
