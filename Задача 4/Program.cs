Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

if ((number2 < number1) && (number1 > number3))
{
    System.Console.WriteLine("Максимальное " +number1);
}
else if ((number1 < number2) && (number2 > number3))
{
    System.Console.WriteLine("Максимальное " +number2);
}
else
    {
        System.Console.WriteLine("Максимальное " +number3);
    }