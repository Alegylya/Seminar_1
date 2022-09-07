void SumOfNumbers()
{
    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }

System.Console.WriteLine($"Массив {String.Join(", ", array)}");

    for (int j = 0; j < array.Length; j++)
    {
        array[j] = -array[j];
    }
System.Console.WriteLine($"Массив новый {String.Join(", ", array)}");
}

SumOfNumbers();
