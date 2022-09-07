int[] EnterArray()
{
    int[] array = new int[5];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 123);
    }

    return array;
}


void CountElement(int[] array)
{

System.Console.WriteLine($"Массив {String.Join(", ", array)}");

int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if  (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
System.Console.WriteLine($"Количество элиментов то 10 до 99 --> {count}");
}

// void Main(int[] array)
// {
//     System.Console.WriteLine($"Введите число поиска");
//     int number = Convert.ToInt32(Console.ReadLine());

//     System.Console.WriteLine($"Массив {String.Join(", ", array)}");

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) return true;
//     }

//     return false;
// }

//Main(EnterArray());
CountElement(EnterArray());
