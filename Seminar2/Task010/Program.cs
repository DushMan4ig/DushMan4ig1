Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int result = firstDigit % 10;
Console.Write(result);