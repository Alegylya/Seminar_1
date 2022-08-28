using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maxnumber();
        }
        static void Maxnumber()
        {
            int number1 = new Random().Next(10,1000);

            int max = 0;

            int iterator = number1;

            while(iterator != 0)
            {
                int number2 = iterator % 10;
                if(number2 > max) max = number2;

                iterator /=10;
            }
            System.Console.WriteLine($"Число{number1} Max {max}");
        }

    }
}
   
