Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainsDigit = RemainsDigit(number1, number2);

Console.WriteLine(remainsDigit == 0 ? "Кратно" : $"Не кратно, остаток -> {remainsDigit}");

int RemainsDigit(int num1, int num2)
{
    return num1 % num2;
}