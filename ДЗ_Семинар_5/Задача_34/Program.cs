// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] EnterArray()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }

    return array;
}

void CountElement(int[] array)
{

System.Console.WriteLine($"Массив [{String.Join(", ", array)}]");

int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if  (array[i] % 2 == 0 )
        {
            count++;
        }
    }
System.Console.WriteLine($"Количество четных элиментов --> {count}");
}

CountElement(EnterArray());
