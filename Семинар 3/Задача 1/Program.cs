using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Введите четверть");
           int quaternumber = int.Parse(Console.ReadLine());

            if (quaternumber == 1)
            {
                System.Console.WriteLine("x > 0, y < 0");
            }
            else if (quaternumber == 2)
            {
                System.Console.WriteLine("x < 0, y > 0");
            }
           else if (quaternumber == 3)
            {
                System.Console.WriteLine("x < 0, y < 0");
            }
           else if (quaternumber == 4)
            {
                System.Console.WriteLine("x > 0, y < 0");
            }
            else
            {
                System.Console.WriteLine($"{quaternumber} нет такой четверти");
            }
        }
    }
}