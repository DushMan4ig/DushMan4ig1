﻿Console.Write("Введите число: ");
string number = Console.ReadLine();

void Palindrom(string number){
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  Palindrom(number);
}
else Console.WriteLine($"Введи правильное число");