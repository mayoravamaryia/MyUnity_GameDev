using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers: ");

            int value1, value2, value3, value4, maxEvenValue;
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = Convert.ToInt32(Console.ReadLine());
            value4 = Convert.ToInt32(Console.ReadLine());

            bool result1, result2, result3, result4;
            result1 = value1 % 2 == 0;
            result2 = value1 % 2 == 0;
            result3 = value1 % 2 == 0;
            result4 = value1 % 2 == 0;

            maxEvenValue = int.MinValue;



            switch (result1 && maxEvenValue < value1)
            {
                case true:
                    {
                        maxEvenValue = value1;
                        break;
                    }
            }
            switch (result2 && maxEvenValue < value2)
            {
                case true:
                    {
                        maxEvenValue = value2;
                        break;
                    }
            }
            switch (result3 && maxEvenValue < value3)
            {
                case true:
                    {
                        maxEvenValue = value3;
                        break;
                    }
            }
            switch (result4 && maxEvenValue < value4)
            {
                case true:
                    {
                        maxEvenValue = value4;
                        break;
                    }
            }

           Console.WriteLine($"Max even number is {maxEvenValue}");

            //switch (maxEvenValue)
            //{
            //    case int.MinValue:
            //        {
            //            Console.WriteLine("Not found");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine($"Max even number is {maxEvenValue}");
            //            break;
            //        }
            //}
        }
    }
}

