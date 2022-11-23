using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
    static void Main(string[] args)
    {
            double op1 = 4.6;
            double op2 = -34.72;

            double sum = op1 + op2;
            double dif = op1 - op2;
            double mul = op1 * op2;
            double div = op1 / op2;

            Console.WriteLine($"{op1} + {op2} = {sum}");
            Console.WriteLine($"{op1} - {op2} = {dif}");
            Console.WriteLine($"{op1} * {op2} = {mul}");
            Console.WriteLine($"{op1} / {op2} = {div}");
        }
}

}
