using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int[] array = new int[8];

        for(int i = 0; i <8; i++)
        {
            array[i] = new Random().Next(0,2);
            System.Console.Write(array[i]+" ");
        }
        System.Console.WriteLine();
        }
    }
}