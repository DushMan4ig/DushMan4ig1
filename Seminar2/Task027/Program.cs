// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sumNumbers = SumNumbers(number);
// Console.WriteLine($"Сумма цифр {number} в числе -> {sumNumbers} ");


// int SumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//        sum = sum + i; 
//     }
//     return sum;
// }
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
{
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number /= 10;
    }
   return result;
}

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");
