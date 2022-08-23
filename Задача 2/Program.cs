Console.WriteLine("Введите первое число ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
    System.Console.WriteLine("Максимальное " +numberFirst);
    System.Console.WriteLine("Минимальное " +numberSecond);
}
else
{
    System.Console.WriteLine("Максимальное " +numberSecond);
    System.Console.WriteLine("Минимальное " +numberFirst);
}