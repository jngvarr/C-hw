// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int IntPrompt(string msg)
{
    Console.Write(msg + " >");
    return int.Parse(Console.ReadLine());
}

double[,] CreateTwoDimArray(int row, int col)
{
    double[,] arr = new double[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
    }
    return arr;
}

void PrintTwoDimArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:F2}" + " ");
        }
        Console.WriteLine();
    }
}
void Execute()
{
    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    double[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);
}
Execute();