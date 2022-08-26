int[] array = { 23, 34, 56, 4, 34, 234,  56, 34 };

int n = array.Length;
int find = 34;

int index  = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
