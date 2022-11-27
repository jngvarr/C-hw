//Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.


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

int[,] SortRowsElements(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        //min=arr[i,j];
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                {
                    if (arr[i, j] > arr[i, k])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
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
    SortRowsElements(arr);
    Console.WriteLine("Упорядоченный массив:");
    PrintTwoDimArray(arr);
}
Execute();