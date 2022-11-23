using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой в теле метода Main примите от пользователя три 
стороны треугольника. Далее:
1. Проведите проверку – возможен ли треугольник с такими сторонами. 
2. Если возможен – проверьте, является ли треугольник прямоугольным, 
равносторонним и равнобедренным. 
3. Выведите информацию о треугольнике на экран. */


            Console.Write("Enter triangle's parametr a: ");
            string param1 = Console.ReadLine();

            Console.Write("Enter triangle's parametr b: ");
            string param2 = Console.ReadLine();

            Console.Write("Enter triangle's parametr c: ");
            string param3 = Console.ReadLine();

            int a = Convert.ToInt32(param1);
            int b = Convert.ToInt32(param2);
            int c = Convert.ToInt32(param3);

                        
            bool possibleTriangle = a + b > c;

            if (possibleTriangle)
            {
                bool rectangularTriangle = (a ^ 2) + (b ^ 2) == c;
                bool equilateralTriangle1 = a == b;
                bool equilateralTriangle2 = b == c;

                if (rectangularTriangle)
                    {
                    Console.WriteLine("This triangle is rectangular!");
                    }
                        
                    else if (equilateralTriangle1 && equilateralTriangle2)
                    {
                        Console.WriteLine("This triangle is equilateral!");
                    }

                    else if (equilateralTriangle1 || equilateralTriangle2)
                    {
                        Console.WriteLine("This triangle is isoskales!");
                    }

                    else
                    {
                        Console.WriteLine("This triangle isn't rectangular or equilateral or isoscales!");
                    }
                
            }
           
        }

    
    }
}
