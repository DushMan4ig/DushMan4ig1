double numberA, numberB;
Console.WriteLine("Введите первое число");
numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
numberB = double.Parse(Console.ReadLine());
double index = 1;
if (numberA > numberB)
{
    Console.WriteLine("Первое число больше");

}

else
{
    Console.WriteLine("Второе число больше");

}