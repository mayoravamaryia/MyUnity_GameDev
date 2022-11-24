using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой примите от пользователя значения двух длин 
сторон прямоугольника. Далее пользователь вводит строковую команду «площадь» 
или «периметр». Если пользователь ввел «площадь» - вывести на экран значение 
площади фигуры. Если пользователь ввел «периметр» - вывести на экран значение 
периметра. Если пользователь ввел какую-либо другую строку – выведите 
«Неверная команда!».
Если прямоугольник является квадратом – дополнительно выведите на экран фразу: 
«данный прямоугольник – квадрат». */

            
            int a, b, area, perimeter;
            Console.Write("Enter side a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side b: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What you want to calculate, perimiter or area: \n");
            string calculated = Console.ReadLine();

            if (calculated == "perimeter")
            {
                perimeter = a + b;
                Console.WriteLine($"Rectangle perimeter is {perimeter}.");
            }
            else if (calculated == "area")
                {
                area = a * b;
                Console.WriteLine($"Rectangle area is {area}.");
            }
            else if (a == b)
            {
                Console.WriteLine("This rectangle is a square");
            }
            else
            {
                ;
            }

            Console.ReadKey();
        }
    }
}
