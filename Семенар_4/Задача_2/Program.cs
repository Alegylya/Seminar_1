using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int index =  0;
        
        while (number > 0)
        {
            number = number / 10;
            index++;
        }
        System.Console.WriteLine(index);
        }
    }
}