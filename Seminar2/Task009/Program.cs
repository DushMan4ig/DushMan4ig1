﻿int number = new Random ().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");
//int firstDigit = number / 10;
//int secondDigit = number % 10;
//int result = firstDigit > secondDigit ? firstDigit : secondDigit;- тернарный оператор
//int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}