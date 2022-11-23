using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueOfGreatTypr = 256; // Cast int to byte
            byte valueOfLowerType = (byte)valueOfGreatTypr;

            Console.WriteLine(valueOfGreatTypr);
            Console.WriteLine(valueOfLowerType);

            Console.ReadKey();
        }
    }
}
