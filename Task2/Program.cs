// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив                               Новый массив будет выглядеть 
// вот так:                                                  выглядел вот так:
// 1   4  7  2                                               1   4   7   2 
// 5  81  2  9                                               5   9   2   3
// 8   4  2  4                                               8   4   2   4

int Prompt(string msg)
{
    Console.Write(msg);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

void PrintArray(int[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        Console.Write($"{arrNums[i, 0]} ");
        for (int j = 0; j < arrNums.GetLength(0); j++)
        {
            Console.Write($"{arrNums[i, j]}\t");
        }
        Console.WriteLine("");
    }
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] GetNewArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i+=2)
    {
        for (int j = 1; j < array.GetLength(1); j+=2)
        {
            array[i, j] *= array[i, j];
        }
    }
    return array;
}

void Execute()
{
    int m = Prompt("Input amount of rows: ");
    int n = Prompt("Input amount of columns: ");
    int[,] array = CreateArray(m, n);
    PrintArray(array);
    Console.WriteLine();
    int[,] newArray = GetNewArray(array);
    PrintArray(newArray);
}

Execute();
