int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg1 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
array[0] = 12; 
System.Console.WriteLine(array[4]);

// int max = Max(
//     Max(array, b1, c1),
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));

// System.Console.WriteLine(max);