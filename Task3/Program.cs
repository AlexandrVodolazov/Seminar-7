// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

double[,] CreateRandomMatrix(int rows, int columns, int minRandom = 0, int maxRandom = 10)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = GetRandomReal(minRandom, maxRandom);
        }
    }
    return matrix;
}

void PrintMatrixReal(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f0}\t");
        }
        Console.Write("\n");
    }
}

double GetRandomReal(int minRandom, int maxRandom)
{
    return new Random().Next(minRandom, maxRandom);
}

double GetDiagonalSum(double[,] matrix)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

double[,] matrix = CreateRandomMatrix(5, 5, 0, 10);
PrintMatrixReal(matrix);
Console.Write($"\n{GetDiagonalSum(matrix):N0}");

