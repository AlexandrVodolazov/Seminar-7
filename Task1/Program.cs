// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            Console.Write($"{arrNums[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Execute()
{
    int intM = Prompt(msg: "enter dimension M (string): ");
    int intN = Prompt(msg: "enter dimension N (columns): ");
    int[,] tempArray = FillArray(m: intM, n: intN);
    PrintArray(arrNums: tempArray);
}

Execute();


