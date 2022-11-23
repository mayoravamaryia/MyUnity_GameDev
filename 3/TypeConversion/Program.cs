using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte valueOfLowerType = 255;
            int valueOfGreatType = valueOfLowerType; // Cast byte to int

            Console.WriteLine(valueOfLowerType);
            Console.WriteLine(valueOfGreatType);

            Console.ReadKey();
        }
    }
}
