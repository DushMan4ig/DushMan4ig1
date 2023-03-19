bool IsExistTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b) return true;
    else return false;
}
Console.WriteLine("Введите длину стороны A: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны B: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны C: ");
int sideC = Convert.ToInt32(Console.ReadLine());
string output = IsExistTriangle(sideA, sideB, sideC) ? "Треугольник может существовать с такими сторонами" : 
"Треугольник не может сущетсвовать с такими сторонами";
Console.WriteLine(output);
