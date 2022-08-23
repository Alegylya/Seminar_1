Console.WriteLine("Введите число ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

int numberSecond = 2;
while (numberSecond <= numberFirst)
{
    Console.Write(numberSecond + ",");
    numberSecond = numberSecond + 2;
}