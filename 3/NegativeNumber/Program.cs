using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negativeNumber = -1; // 11111111 11111111 11111111 11111111
            uint naturalNumber = 4294967295; // 11111111 11111111 11111111 11111111

            Console.WriteLine(negativeNumber);
            Console.WriteLine(naturalNumber);

            // Check in binary system
            Console.WriteLine(Convert.ToString(negativeNumber, 2));
            Console.WriteLine(Convert.ToString(naturalNumber, 2));  

            Console.ReadKey();
        }
    }
}
