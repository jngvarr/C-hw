// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateRandomArr()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}
void PrintArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

int EvenNumb(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

int[] arr = CreateRandomArr();
PrintArr(arr);
Console.WriteLine();
Console.Write($"Количество четных элементов в массиве {EvenNumb(arr)}");