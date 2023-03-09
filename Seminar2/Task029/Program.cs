int[] array = new int [8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i] }  ");
    }
} 

FillArray(array);
PrintArray(array);