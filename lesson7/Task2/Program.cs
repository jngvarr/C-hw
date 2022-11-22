// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:           Новый массив будет выглядеть вот так:
// 1 4 7 2                     1   4  7  2
// 5 9 2 3                     5  81  2  9
// 8 4 2 4                     8   4  2  4

int IntPrompt(string msg)
{
    Console.Write(msg + " >");
    return int.Parse(Console.ReadLine());
}

int[,] CreateTwoDimArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintTwoDimArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] EvenIdexesPow(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 1; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
    return arr;
}

void Execute()
{
    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    int[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);
    int[,] arrValuePow = EvenIdexesPow(arr);
    PrintTwoDimArray(arrValuePow);
}
Execute();