using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for(int i=0; i <= number; i++)
        {
            sum += i;
        }
        System.Console.WriteLine(sum);
        }
    }
}