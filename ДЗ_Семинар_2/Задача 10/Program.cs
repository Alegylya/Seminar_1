using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
           int number = new Random().Next(100,1000);

           int result = ((number / 10) % 10 );
           System.Console.WriteLine($"number={number}; ={result} ");
        }
        
    }
}
   
