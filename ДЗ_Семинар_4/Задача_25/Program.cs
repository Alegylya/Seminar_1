using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
            double result = Math.Pow(number1,number2);
            System.Console.WriteLine($"{number1}, {number2} --> {result}");
        }
    }
}