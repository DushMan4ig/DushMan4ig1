﻿int max = 0;
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > max)
{
    max = numberA;
}
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}

Console.WriteLine("max = " + max);