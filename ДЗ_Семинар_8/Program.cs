Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("54) Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        System.Console.WriteLine("56) Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        System.Console.WriteLine("58) Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        System.Console.WriteLine("60) Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2x2x2");
        System.Console.WriteLine("62) Задача 62: Напишите программу, которая заполнит спирально массив 4X4.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 54:
            Zadacha54();
            break;
            
            case 56:
            Zadacha56();
            break;

            case 58:
            Zadacha58();
            break;

            case 60:
            Zadacha60();
            break;

            case 62:
            Zadacha62();
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
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}
void Zadacha54()
{
    Console.WriteLine("Введите m: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int m = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [m,n];

    FillArrayRandomNumbers(array);
    Console.WriteLine("Массив");
    PrintArray(array);

    Console.WriteLine("Отсортированный массив");
    OrderArrayLines(array);
    PrintArray(array);
}
void Zadacha56()
{
    Console.WriteLine("Число m должно быть больше числа n");
    Console.WriteLine("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if (m > n)
    {
        int [,] array = new int [m,n];

        FillArrayRandomNumbers(array);
        Console.WriteLine("Массив");
        PrintArray(array);

        int SumLine(int[,] array, int i)
        {
            int sumLine = array[i,0];
            for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i,j];
        }
            return sumLine;
        }

        int minSumLine = 0;
        int sumLine = SumLine(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = SumLine(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        }
        Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
    }
    else 
    {
        System.Console.WriteLine("error");
    }
}
void Zadacha58()
{
    Console.WriteLine("Введите m: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите n:");
    int m = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [m,n];

    int[,] FirstArray = new int[m, n];
    FillArrayRandomNumbers(FirstArray);
    Console.WriteLine("Первый массив");
    PrintArray(FirstArray);

    int[,] SecondArray = new int[m, n];
    FillArrayRandomNumbers(SecondArray);
    Console.WriteLine("Второй Массив");
    PrintArray(SecondArray);

    int[,] ResultArray = new int[m, n];
    SumArray(FirstArray, SecondArray, ResultArray);
    Console.WriteLine("Произведение двух массивов");
    PrintArray(ResultArray);
    
}
void Zadacha60()
{
    Console.WriteLine("Введите размер массива x,y,z. ");
    
    Console.WriteLine("Введите x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите y:");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите y:");
    int z = Convert.ToInt32(Console.ReadLine());

    int[,,] array3D = new int[x, y, z];
    CreateArray(array3D);
    WriteArray(array3D);
}
void Zadacha62()
{
    int n = 4;
    int[,] sqareArray = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareArray.GetLength(0) * sqareArray.GetLength(1))
    {
        sqareArray[i, j] = temp;
        temp++;
    if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
        j--;
    else
        i--;
    }

    for (int k = 0; k < sqareArray.GetLength(0); k++)
  {
    for (int l = 0; l < sqareArray.GetLength(1); l++)
    {
      if (sqareArray[k,l] / 10 <= 0)
      Console.Write($" {sqareArray[k,l]} ");

      else Console.Write($"{sqareArray[k,l]} ");
    }
    Console.WriteLine();
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
void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
void SumArray(int[,] FirstArray, int[,] SecondArray, int[,] ResultArray)
{
  for (int i = 0; i < ResultArray.GetLength(0); i++)
  {
    for (int j = 0; j < ResultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < FirstArray.GetLength(1); k++)
      {
        sum += FirstArray[i,k] * SecondArray[k,j];
      }
      ResultArray[i,j] = sum;
    }
  }
}
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(0, 10);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(0, 10);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}