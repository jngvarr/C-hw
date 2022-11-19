// Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
//Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

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

int RowsMaximumCalculate(int[,] arr)
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
        sum += max;
    }

    return sum;
}

int ColumnsMinimumCalculate(int[,] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int min = arr[0, j];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (arr[i, j] < min)
                min = arr[i, j];
        }
        sum += min;
    }

    return sum;
}

int rows = IntPrompt($"Введите количество строк массива:");
int columns = IntPrompt($"Введите количество столбцов массива:");
int[,] arr = CreateTwoDimArray(rows, columns);
PrintTwoDimArray(arr);
int max=RowsMaximumCalculate(arr);
int min=ColumnsMinimumCalculate(arr);
Console.WriteLine($"Сумма максимальных элементов строк массива: {max}.");
Console.WriteLine($"Сумма минимальных элементов столбцов массива: {min}.");
Console.WriteLine($"Раность полученных максимумов: {max-min}.");