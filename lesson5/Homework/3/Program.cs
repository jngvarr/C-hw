// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArr()
{
    double[] arr = new double[10];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =  rand.NextDouble();
    }
    return arr;
}
void PrintArr(double[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

double OddNumbSumm(double[] arr)
{
    double summ = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    return summ;
}

double[] arr = CreateRandomArr();
PrintArr(arr);
Console.WriteLine();
Console.Write($"Сумма элементов на нечетных позициях в массиве -> {OddNumbSumm(arr)}");