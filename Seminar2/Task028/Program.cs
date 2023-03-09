Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = Factororial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {sumNumbers}");


int Factorial(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
       sum = sum * i; 
    }
    return sum;
}
