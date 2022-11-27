//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
bool SizeCompare(int row2, int column1)
{
    if (row2 == column1) return true;
    else return false;
}

int[,] ArrayMultiply(int[,] arr1, int[,] arr2)
{
    int[,] multArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < multArr.GetLength(0); i++)
        for (int j = 0; j < multArr.GetLength(1); j++)
            for (int l = 0; l < arr2.GetLength(0); l++)
                multArr[i, j] += arr1[i, l] * arr2[l, j];
    return multArr;
}

void Execute()
{
    int rows = IntPrompt($"Введите количество строк первого массива:");
    int columns = IntPrompt($"Введите количество столбцов первого массива:");
    int rows2 = IntPrompt($"Введите количество строк второго массива:");
    int columns2 = IntPrompt($"Введите количество столбцов второго массива:");
    if (!SizeCompare(columns, rows2))
    {
        Console.WriteLine("Матрицы с такими параметрами не могут быть перемножены");
    }
    else
    {
        int[,] arr = CreateTwoDimArray(rows, columns);
        PrintTwoDimArray(arr);
        int[,] arr2 = CreateTwoDimArray(rows2, columns2);
        PrintTwoDimArray(arr2);
        int[,] multArray = ArrayMultiply(arr, arr2);
        Console.WriteLine("Результат перемножения матриц:");
        PrintTwoDimArray(multArray);
    }
}
Execute();