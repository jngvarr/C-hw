// Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
//Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int IntPrompt(string msg)
{
    Console.Write(msg + " ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateTwoDimArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[] MaxMinDiffCalculate(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int max = arr[i, 0];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max)
                max = arr[i, j];
        }
        Sum +=max;
    }

    return max;
}

int[,] arr = CreateTwoDimArray(2, 3);
PrintTwoDimArray(arr);
int[] arrMax = MaxMinDiffCalculate(arr);
PrintArray(arrMax);
