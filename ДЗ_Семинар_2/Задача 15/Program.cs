using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи день недели: ");
        int day = Convert.ToInt32(Console.ReadLine());
        if(day == 6 || day == 7)
        {
            System.Console.WriteLine($"День {day} выходной");
        }
        else if(day < 1 || day > 7)
        {
            System.Console.WriteLine("Нет такого дня недели");
        }
        else
        {
            System.Console.WriteLine($"День {day} не выходной");
        }
        }
    }
}