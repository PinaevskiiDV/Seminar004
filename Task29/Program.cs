void FillArray(int[] arr)
{
    int lenght = arr.Length;
    int i;
    for(i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}
int[] array = new int[8];
FillArray(array);
Console.WriteLine(string.Join(",", array));