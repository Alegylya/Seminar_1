﻿using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите пятизначное число");
            string number = Console.ReadLine();
            void CheckingNumber(string number)
            {
                if (number[0]==number[4] && number[1]==number[3])
                {
                    Console.WriteLine($"Число: {number} - палиндром.");
                }
                    else Console.WriteLine($"Число: {number} - НЕ палиндром.");    
            }
           if (number.Length == 5)
           {
            CheckingNumber(number);
           }
            else Console.WriteLine("Введи правильное число");
        }
        
    }
}