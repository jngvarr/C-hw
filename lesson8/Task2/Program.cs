//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это не возможно, программа должна вывести сообщение для пользователя.

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

bool ChangeRowsToColumns(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1)) return false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
        }
    }
    return true;
}

void Execute()
{
    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    int[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);
    if (ChangeRowsToColumns(arr)) PrintTwoDimArray(arr);
    else Console.WriteLine("Количество строк и столбцов массива не совпадает!");
}
Execute();