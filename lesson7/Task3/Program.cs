// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

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
            arr[i, j] = new Random().Next(0, 9);
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
            Console.Write($"{arr[i, j]}" + " ");
        }
        Console.WriteLine();
    }
}

int DiagonalSumm(int[,] arr)
{
    int summ = 0;
    for (int n = 0; n < arr.GetLength(1); n++)
    {
        summ += arr[n, n];
    }
    return summ;
}

void Execute()
{
    int rowcolumns = IntPrompt($"Введите размер массива (количество строк и столбцов) массива:");
    int[,] arr = CreateTwoDimArray(rowcolumns, rowcolumns);
    PrintTwoDimArray(arr);
    Console.Write($"Сумма элементов главной диагонали - {DiagonalSumm(arr)}.");
}
Execute();