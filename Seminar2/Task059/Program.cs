// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
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

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 4}");
        }
    Console.WriteLine();
    }
}

(int Row, int Column) MinElement(int[,] matrix)
{
    int indexMinRow = 0, indexMinColumn = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[indexMinRow, indexMinColumn] > matrix[i, j])
            {
                indexMinRow = i;
                indexMinColumn = j;
            } 
        }
    }
    return(indexMinRow, indexMinColumn); 
}

int[,] DeleteRowColumn(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if(m == row) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if(n == column) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;

        }
        m++;
        n = 0;
    }
    return newMatrix;
}

int[,] arr2d = CreatMatrixRndInt(4, 4, 0, 10);
PrintMatrix(arr2d);
Console.WriteLine();
(int Row, int Column)indexesMin = MinElement(arr2d);
int[,] newArr2d = DeleteRowColumn(arr2d, indexesMin.Row, indexesMin.Column);
PrintMatrix(newArr2d); 

