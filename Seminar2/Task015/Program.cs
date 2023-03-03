Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
         Console.WriteLine("(Выходной) -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Не день недели");
    }
    else Console.WriteLine("(Не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);