using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Введите длину массива");
        int length = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите минимальное число массива");
        int min = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите макстмально число массива");
        int max = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        if(min < max)
        {
        max++;
        for(int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(min,max);
            System.Console.Write(array[i]+" ");
        }
        System.Console.WriteLine();
        }
        else
        {System.Console.WriteLine("Ошибка. Минимальное число больше Максимального");}
        }
    }
}