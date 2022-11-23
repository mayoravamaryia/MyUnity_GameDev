using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month_number = 7;
            if (month_number >= 6 && month_number <= 8)
            {
                Console.WriteLine("Лето");
            }
            else
            {
                Console.WriteLine("Другое время года");
            }
        }
    }
}
