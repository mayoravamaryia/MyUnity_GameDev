using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;
            const double PI = 3.1415926535897931;
            int g = 0, x = 1, y = 2, z = 3, a = 15, b = 4;
            if (x > y & Convert.ToInt32(Console.ReadLine()) < a)
            {
                g = y;
                value = g + PI;
                Console.WriteLine($"число g = {0}, значение value = {1}", g, value);
            }
            else
            {
                if (z == y & z < b)
                    g = z;
                value = g + PI;
                Console.WriteLine($"число g = {g}, значение value = {value}");
            }

            Console.ReadLine();
        }
    }
}
