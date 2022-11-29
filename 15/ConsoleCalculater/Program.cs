using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorForSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу – консольный калькулятор.
Создайте две вещественные переменные и запросите от пользователя значения этих 
переменных. Предложите пользователю ввести знак арифметической операции. 
Используя конструкцию switch-case, в зависимости от введенного символа 
выполните арифметическую операцию сложения, вычитания, умножения или 
деления между вещественными переменными. Выведите результат на экран. В случае деления – выполните дополнительную проверку делителя, чтобы не 
выполнить деление на ноль и отмените выполнение математической операции.
Если пользователь ввел неподходящий символ – выведите на экран “Неподходящий 
символ».  */


            Console.WriteLine("Enter two number: ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the arithmetic operation sign: '+', '-', '*', '/': ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(a * b);
                        break;
                    }
                case "/":
                    {
                        switch (b)
                        {
                            case 0:
                                {
                                    Console.WriteLine("Operation can't be complited");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine(a / b);
                                    break;
                                }
                        }
                        
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Inappropriate symbol");
                        break;
                    }

            }

        }
    }
}
