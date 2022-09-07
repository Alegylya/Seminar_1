// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] EnterArray()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[size];
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }

    return array;
}

void CountElement(int[] array)
{

System.Console.WriteLine($"Массив [{String.Join(", ", array)}]");

int sum = 0;

    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
System.Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях --> {sum}");
}

CountElement(EnterArray());