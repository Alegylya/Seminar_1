using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Введите первое число");
           int number1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Введите второе число");
           int number2 = int.Parse(Console.ReadLine());
            if(number1 > number2)
            {
                if(number1 % number2  == 0)
                {
                    System.Console.WriteLine($"Число {number2} кратное {number1} ");
                }
                else
                {
                    System.Console.WriteLine($"Число {number2} не кратное {number1} ");
                }
            }
            else
            System.Console.WriteLine($"Число {number2} больше {number1} ");
           
        }
        
    }
}
   
