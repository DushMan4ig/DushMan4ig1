int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;

Console.Write(result);