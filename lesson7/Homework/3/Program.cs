// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int IntPrompt(string msg)
{
    Console.Write(msg + ": >");
    return int.Parse(Console.ReadLine());
}

int[,] Create2dimArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Print2DimArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageArithmetic(int[,] arr)
{
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое {j}-го столбца составляет {sum / (arr.GetLength(0)):f2}");
    }
    Console.WriteLine();
}

void Execute()
{
    int row = IntPrompt("Введите количество строк массива");
    int col = IntPrompt("Введите количество столбцов массива");
    int[,] arr = Create2dimArray(row, col);
    Print2DimArray(arr);
    AverageArithmetic(arr);
}
Execute();