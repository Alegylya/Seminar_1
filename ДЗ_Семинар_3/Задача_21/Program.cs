using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("x1:");
        int x1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("y1:");
        int y1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("z1:");
        int z1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("x2:");
        int x2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("y2:");
        int y2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("z2:");
        int z2 = int.Parse(Console.ReadLine());


        double result = Math.Sqrt (Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));

        System.Console.WriteLine($"А (Длина отрезка {result:f2}");

        }
    }
}