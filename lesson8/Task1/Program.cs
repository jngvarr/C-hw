///Задайте двумерный массив.Напишите программу, которая поменяет местами первую и последнюю строки.

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
int[,] ChangeFirstAndLastRows(int[,] arr)
{
    int temp = 0;
    int n = arr.GetLength(1);
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
        //(arr[0,j],arr[arr.GetLength(0)-1,j])=(arr[arr.GetLength(0)-1,j],arr[0,j]); //- одно из решений семинара
    }
    return arr;
}

void Execute()
{
    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    int[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);
    PrintTwoDimArray(ChangeFirstAndLastRows(arr));
}
Execute();