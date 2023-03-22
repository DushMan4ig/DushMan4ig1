// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
//     0   1   2   3
// 0   1   4   8   19
// 1   5   -2  33  -2
// 2   77   3   8   1

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // Создание двухмерного массива; rows = matrix.GetLength(0), columns = matrix.GetLength(1)
    Random rnd = new Random();

    for (int j= 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          matrix[i, j] = rnd.Next(min, max + 1);  
        }
    } 
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
    Console.WriteLine();
    }
}
int[,] array2d = CreatMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);