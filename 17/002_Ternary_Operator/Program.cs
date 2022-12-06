using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1. Получите от пользователя два целых числа. 
             * 2. Используя выражение, в котором тернарный оператор располагается слева от 
оператора присвоения, выполните проверку на то, что первое введенное число 
больше или равно второму. 
            3. (в том же выражении) Если проверка возвращает true – первому числу должно 
присвоится значение 100, иначе 100 должно присвоится второму введенному 
числу.
            4. Выведите информацию о числах и их итоговых значениях на экран консоли.
 */
            Console.WriteLine("Enter your numbers: ");

            int x, y, result;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            result = (x >= y) ? x += 100 : y += 100;
            
            Console.WriteLine(result);



        }
    }
}
