// Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец а пересечении которых расположен наименьший элемент.

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

    int rows = IntPrompt($"Введите количество строк массива:");
    int columns = IntPrompt($"Введите количество столбцов массива:");
    int[,] arr = CreateTwoDimArray(rows, columns);
    PrintTwoDimArray(arr);


int minI = 0;
int minJ = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[minI, minJ] > arr[i, j])
        {
            minI = i;
            minJ = j;
        }
    }
}

int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (minI != i && minJ != j)
        {
            int k = i;
            int l = j;
            if (k > minI) k--;
            if (l > minJ) l--;
            newArr[k, l] = arr[i, j];
        }
    }
}
PrintTwoDimArray(newArr);