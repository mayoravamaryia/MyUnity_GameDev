using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            
            x += y++ * z;
            z = --x - y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;


            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(x);


            Console.ReadKey();

        }
    }
}
