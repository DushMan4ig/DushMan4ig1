﻿// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumber(int num)
{

    if(num == 0) return 0;
    return SumNumber(num / 10) + num % 10;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(SumNumber(number));