Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Number = 2;
if (number > 1)
{
    while (Number <= number)
    {
        Console.WriteLine(Number + " ");
        Number = Number + 2;
    }
}