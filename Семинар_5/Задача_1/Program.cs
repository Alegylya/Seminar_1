void SumOfNumbers()
{
    int[] array = new int[12];

    int sumPositiv = 0;
    int sumNigativ = 0;
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
        if (array[i] > 0 )
        {
            sumPositiv += array[i];
        }
        else 
        {
            sumNigativ += array[i];
        }
    }

System.Console.WriteLine($"Массив {String.Join(", ", array)}");
System.Console.WriteLine($"Сумма позитивны чисел {sumPositiv}");
System.Console.WriteLine($"Сумма негативных чисел {sumNigativ}"); 

}

SumOfNumbers();
