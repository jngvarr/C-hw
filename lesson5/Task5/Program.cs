// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] RndmArr(int qntty, int lowVal, int hiVal)
{
    int[] arr = new int[qntty];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lowVal, hiVal);
    }
    return arr;
}

int Prompt(string msg)
{
    Console.WriteLine(msg + " >");
    return int.Parse(Console.ReadLine());
}

void PrntArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

int[] MultypliPairs(int[] arr)
{
    int[] newArr = new int[arr.Length / 2 + arr.Length % 2];
    newArr[newArr.Length-1]=arr[newArr.Length-1];
    for (int i = 0; i < (arr.Length) / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArr;
}

int len = Prompt($"Введите количество элементов массива");
int lowVal = 0;
int hiVal = 10;

int[] array = RndmArr(len, lowVal, hiVal);
Console.WriteLine($"Наш массив: ");
PrntArr(array);
Console.WriteLine();
Console.WriteLine($"Новый массив:");
PrntArr(MultypliPairs(array));
