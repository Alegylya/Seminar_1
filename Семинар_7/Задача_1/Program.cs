Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("47) Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        System.Console.WriteLine("50) Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        System.Console.WriteLine("52) Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 47:
                
                GetArray();

                //Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");
                break;
            // case 50:
            //     Console.Clear();
            //     startArray = GetArray(6, 0, 999);
            //     Console.WriteLine(String.Join(" ", startArray));
            //     Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");

            //     break;

            // case 52:

            //     Console.Write("Введите элементы массива через пробел: ");
            //     string elements = Console.ReadLine();
            //     int[] baseArray = GetArrayFromString(elements);
            //     Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

            //     break;

            default: System.Console.WriteLine("error"); break;
        }
    }
}


int [,] GetArray()
{
    Console.Clear();

    Console.Write("Введите количество строк массива:");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива:");
    int columns = int.Parse(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }    
    return array;
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

