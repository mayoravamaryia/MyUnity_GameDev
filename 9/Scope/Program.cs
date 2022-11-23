using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            {
                a = 5;
            }
            {
                a++;
            }
            
            Console.WriteLine(--a);
            
            Console.ReadKey();
        }
    }
}
