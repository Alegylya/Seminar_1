using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"Таблица квадратов");

        for(int i = 1; i <= number; i++)
        {
            System.Console.WriteLine(Math.Pow(i,2));
        }
        }
    }
}