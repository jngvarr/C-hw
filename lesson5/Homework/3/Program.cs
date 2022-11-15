// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArr()
{
    double[] arr = new double[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10) + new Random().NextDouble();
    }
    return arr;
}
void PrintArr(double[] arr)
{
    Console.Write($"{arr[0]:F2}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]:F2}");
    }
}

double MaxMinDifference(double[] arr)
{
    double max = arr[0]; double min = arr[0];
    for (int i = 0; i < arr.Length; i += 2)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine($"max = {max:F2}");
    Console.WriteLine($"min = {min:F2}");
    return max - min;
}

double[] arr = CreateRandomArr();
PrintArr(arr);
Console.WriteLine();
Console.Write($"Разность максимального и минимального элементов массива -> {MaxMinDifference(arr):F2}");