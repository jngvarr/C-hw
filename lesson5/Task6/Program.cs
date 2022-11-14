//Создать массив и посчитать среднеарифметическое

int[] RndmArr(int qntty = 10, int lowVal = 0, int hiVal = 10)
{
    int[] arr = new int[qntty];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lowVal, hiVal);
    }
    return arr;
}
double Average(int[] arr)
{
    double total = 0;
    foreach (var item in arr)
    {
        total += item;
    }
    return total / arr.Length;
}

double MidSquare(int[] arr)
{
    double total = 0;
    foreach (var item in arr)
    {
        total += Math.Pow(item, 2);
    }
    return Math.Sqrt(total / arr.Length);
}

void PrntArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

int[] numbers = RndmArr();
PrntArr(numbers);
Console.WriteLine();
Console.WriteLine(Average(numbers));
Console.WriteLine($"{MidSquare(numbers):F2}");