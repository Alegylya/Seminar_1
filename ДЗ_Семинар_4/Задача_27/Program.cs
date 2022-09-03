using System;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.Write("Введите число N: ");
        int number1 = Convert.ToInt32(Console.ReadLine());    
        int counter = Convert.ToString(number1).Length;
        int number2 = 0;
        int result = 0;

        for (int i = 0; i < counter; i++)
        {
            number2 = number1 - number1 % 10;
            result = result + (number1 - number2);
            number1 = number1 / 10;
        }
        Console.WriteLine("Сумма цифр в числе: " + result);
        }
    }
}