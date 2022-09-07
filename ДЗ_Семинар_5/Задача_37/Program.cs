// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] EnterArray()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[size];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

    return array;
}

void CountElement(int[] array)
{

System.Console.WriteLine($"Массив [{String.Join(", ", array)}]");

int sum = 0;

    for (int i = 0; i <= array.Length - (i+1); i++)
    {
        if (array[i] != array[array.Length - (i+1)])
        {
            sum = array[i] * array[array.Length - (i+1)];
            System.Console.Write($"{sum}, ");
        }
        else
        {
            System.Console.Write($"{array[i]} ");
        }
        

    }
}

CountElement(EnterArray());