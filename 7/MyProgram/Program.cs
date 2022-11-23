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
            /* Напишите программу, выполняющую «зашифровку» и «расшифровку» введенного
                пользователем символа. Ключом шифрования считайте число 216. Выведите на экран
                консоли зашифрованный символ и расшифрованный.*/

            char symbol = Console.ReadLine('');
            

            int key = 216;
            Console.WriteLine($"key = {key}");

            char encryptedValue = (char)(symbol ^ key);
            Console.WriteLine($"encryptedValue = {encryptedValue}");

            char decryptedValue = (char)(encryptedValue ^ key);
            Console.WriteLine($"decryptedValue = {decryptedValue}");

            // Delay
            Console.ReadKey();
        }
    }
}
