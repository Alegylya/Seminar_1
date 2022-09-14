void Tringle()

{
System.Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine()); 

System.Console.WriteLine("Введите число 3");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number2 + number1)
{
    System.Console.WriteLine("Такой  треугольник существует");
}
else
{
    System.Console.WriteLine("Такой треугольник НЕ существует");
}
}

void Zadacha42()

{
    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine();

    int value = number;
    int count = 0;
    int temp = number;

    while (number !=0)
    {
        number = number / 2;
        count++;
    }

    int[] Binarr = new int[count];

    count--;
    while (temp !=0)
    {
        Binarr[count] = temp % 2;
        temp = temp / 2;
        count--;
    }
    System.Console.WriteLine(String.Join("",Binarr));
    System.Console.WriteLine(Convert.ToString(value, 2));
}
//Zadacha42();

static void Fibonaci(int number)
{
    int[]array = new int[number];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < number; i++)
        {
            array[i] = array[i-1] + array[i-2];
        }
    System.Console.WriteLine(String.Join(' ',array));
}
//Fibonaci(7);

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


static int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }

    return copy;
}

int[] array = EnterArray();
int[] array2 = CopyArray(array);
System.Console.WriteLine(String.Join(" ", array)); 
System.Console.WriteLine(String.Join(" ", array2)); 