Console.WriteLine($"Введите номер четверти");
Console.Write("Четверть:");
string quarter = Console.ReadLine();

string range = FindRange (quarter);
Console.WriteLine(range);

string FindRange (string quart)
{
    if(quart == "1") return "x > 0 и y > 0";
    if(quart == "2") return "x < 0 и y > 0";
    if(quart == "3") return "x < 0 и y < 0";
    if(quart == "4") return "x > 0 и y < 0";
    return "Не соотвествует никакой четверти";
    
}
