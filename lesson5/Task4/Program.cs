// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат
// в отрезке [10,99]. 

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

int CountNumb(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >=10 && arr[i]<=99) count++;
    }
    return count;
}

int len = 123;
int lowVal = 0;
int hiVal = 999;

int[] array = RndmArr(len, lowVal, hiVal);
Console.WriteLine($"Наш массив: ");
PrntArr(array);
Console.WriteLine();
Console.WriteLine($"В массиве {CountNumb(array)} элементов от 10 до 99");
