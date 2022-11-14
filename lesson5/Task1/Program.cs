// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] RndmArr(int qntty, int lowVal, int hiVal)
{
    int[] arr = new int[qntty];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lowVal, hiVal);
    }
    return arr;
}

void PrntArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

int Sum(int[] arr, bool isPositive = true)
{
    int invertor = 1;
    if (!isPositive) invertor = -invertor;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i]*invertor) > 0) sum += arr[i];
    }
    return sum;
}

int len = 12;
int lowVal = -9;
int hiVal = 9;

int[] array = RndmArr(len, lowVal, hiVal);
PrntArr(array);

Console.WriteLine();
Console.WriteLine($"Суммма положительных чисел = {Sum(array)}");
Console.WriteLine($"Суммма отрицательных чисел = {Sum(array,false)}");