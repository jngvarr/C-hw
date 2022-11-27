//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int[] GetMinSumRowsArr(int[,] arr)
{
    int sum = 0;
    int[] summ = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        summ[i] = sum;
    }
    return summ;
}


void MinSumRow(int[] arr)
{
    int minSum = arr[0];
    int MinSumElementNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            MinSumElementNumber = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке N {MinSumElementNumber+1}.");
}


void Execute()
{
    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    int[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);
    int[] arr1DIM = GetMinSumRowsArr(arr);
    MinSumRow(arr1DIM);

}
Execute();