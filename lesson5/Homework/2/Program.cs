// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArr()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 20);
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

int OddNumbSumm(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        summ+=arr[i];
    }
    return summ;
}

int[] arr = CreateRandomArr();
PrintArr(arr);
Console.WriteLine();
Console.Write($"Сумма элементов на нечетных позициях в массиве -> {OddNumbSumm(arr)}");