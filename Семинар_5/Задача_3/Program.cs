int[] EnterArray()
{
    System.Console.WriteLine("Введите длинну массива");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }

    return array;
}


void Main(int[] array)
{

System.Console.WriteLine($"Массив {String.Join(", ", array)}");

    for (int j = 0; j < array.Length; j++)
    {
        array[j] = -array[j];
    }
System.Console.WriteLine($"Массив новый {String.Join(", ", array)}");
}

bool IsInArray(int[] array)
{
    System.Console.WriteLine($"Введите число поиска");
    int number = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine($"Массив {String.Join(", ", array)}");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }

    return false;
}

//Main(EnterArray());
System.Console.WriteLine(IsInArray(EnterArray()));
