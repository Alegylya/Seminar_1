// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

FillArray(array);
System.Console.WriteLine($"Массив [{String.Join("  ", array)}]");

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

System.Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементов массива --> {max-min}.");