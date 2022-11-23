using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Если выслуга до 5 лет, премия составляет 10 % от заработной платы. 
            Если выслуга от 5 лет(включительно) до 10 лет, премия составляет 15 % от заработной
            платы.
            Если выслуга от 10 лет(включительно) до 15 лет, премия составляет 25 % от заработной
            платы.
            Если выслуга от 15 лет(включительно) до 20 лет, премия составляет 35 % от заработной
            платы.
            Если выслуга от 20 лет(включительно) до 25 лет, премия составляет 45 % от заработной
            платы.
            Если выслуга от 25 лет(включительно) и более, премия составляет 50 % от заработной
            платы.*/

            Console.Write("Your Surname: ");
            Console.ReadLine();

            int fiveLenght = 5, tenLenght = 10, fiveteenLenght = 15, twentyLenght = 20, twentyfiveLenght = 25;

            Console.Write("Your lenght of Service: ");

            int yourCondition = Convert.ToInt32(Console.ReadLine());

           
            bool condition1 = fiveLenght >= yourCondition;
            bool condition2 = fiveLenght <= yourCondition && yourCondition <= tenLenght;
            bool condition3 = tenLenght <= yourCondition && yourCondition <= fiveteenLenght;
            bool condition4 = fiveteenLenght <= yourCondition && yourCondition <= twentyLenght;
            bool condition5 = twentyLenght <= yourCondition && yourCondition <= twentyfiveLenght;
            bool condition6 = twentyfiveLenght <= yourCondition;

           
            Console.WriteLine($"Your award 10%: {condition1}");
            Console.WriteLine($"Your award 15%: {condition2}");
            Console.WriteLine($"Your award 25%: {condition3}");
            Console.WriteLine($"Your award 35%: {condition4}");
            Console.WriteLine($"Your award 45%: {condition5}");
            Console.WriteLine($"Your award 50%: {condition6}");


        }
    }
}
