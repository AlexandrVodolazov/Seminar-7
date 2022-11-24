// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

int Prompt(string msg)
{
    Console.Write(msg);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

int[,] CreateArray(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(-9, 9);
        }
    }
    return table;
}

void FindElement (int [,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number)
            {
                Console.WriteLine($"the element {number} exists, position [{i}, {j}]");
            }
        }
    }
    Console.WriteLine($"The number was not found in the array");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Execute()
{
    int rows = Prompt("Enter quantity of rows ");
    int columns = Prompt("Enter quantity of columns ");
    int[,] array = CreateArray(rows, columns);
    PrintArray(array);
    int num = Prompt("Enter some number to find in array ");
    FindElement(array, num);
}

Execute();



