﻿double numberA, numberB;
Console.WriteLine("Введите большое целое число");
numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите меньшее целое число");
numberB = double.Parse(Console.ReadLine());
double index = 1;
if (index==numberA/(numberB*numberB))
{
    Console.WriteLine("Квадратом является");

}

else
{
    Console.WriteLine("Квадратом не является");

}