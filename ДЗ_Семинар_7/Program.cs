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
            Zadacha47();

            break;
            case 50:
            Zadacha50();
            
break;

            case 52:
                Zadacha52();
                break;

            default: System.Console.WriteLine("error"); break;
        }
    }
}
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}
void Zadacha50()
{
            Console.WriteLine("введите номер строки");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер столбца");
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] numbers = new int [10,10];

            System.Console.WriteLine($"Массив {String.Join(", ", numbers)}");

            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);

            if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
            else
            {
                Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
            }

            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {        
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array [i,j] = new Random().Next(-100, 100)/10;
                        }   
                }
            }
}
void Zadacha47()
{
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    double[,] array = new double[m, n];

    CreateArrayDouble(array);

    WriteArray(array);

    Console.WriteLine();

    void CreateArrayDouble(double[,] array)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = new Random().NextDouble() * 20 - 10;
            }
        }
    }

    void WriteArray (double[,] array)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double alignNumber = Math.Round(array[i, j], 1);
                Console.Write(alignNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
void Zadacha52()
{
    Console.WriteLine("введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[n, m];

    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        avarage = avarage / n;
        Console.Write(avarage + "; ");
    }
    Console.WriteLine();

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}