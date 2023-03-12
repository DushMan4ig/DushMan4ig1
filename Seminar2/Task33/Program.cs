int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    } 
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]},");
    }
    Console.WriteLine("]");
}

bool SearchDigit(int[] arr, int dig)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == dig) return true;
    } 
    return false;
}
int[] arr = CreatArrayRndInt(5, -9, 9);
PrintArray(arr);
Console.Write("Введите число : ");
int Digit = Convert.ToInt32(Console.ReadLine());
string output = SearchDigit(arr, Digit) ? "Число присутствует в массиве" : "Число не присутстсвует в массиве";
Console.WriteLine(output);
