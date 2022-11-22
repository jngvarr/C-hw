// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void ElemetsValueReturn(int[,] arr, int row, int col)
{
    if (row <= arr.GetLength(0) && col <= arr.GetLength(1))
    {
        Console.Write($"Введенной позиции {(row, col)} соответствует элемент со значением {arr[row - 1, col - 1]}.");
        return;
    }
    Console.Write("Элемент с заданными параметрами в массиве отсутствует.");

}

void Execute()
{
    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    int[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);
    int rowOut = IntPrompt($"Введите номер строки элемента для вывода:");
    int columnOut = IntPrompt($"Введите номер столбца элемента для вывода:");
    ElemetsValueReturn(arr, rowOut, columnOut);
}
Execute();