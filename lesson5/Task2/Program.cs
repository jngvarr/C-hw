// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] Rotrate(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

int len = 12;
int lowVal = -9;
int hiVal = 9;

int[] array = RndmArr(len, lowVal, hiVal);
Console.WriteLine($"Прямой массив: ");
PrntArr(array);
Console.WriteLine();
Console.WriteLine($"Обратный массив: ");
PrntArr(Rotrate(array));