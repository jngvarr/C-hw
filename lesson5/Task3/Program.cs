// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool IsFindNumb(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}

int Prompt(string msg)
{
    Console.Write(msg + " >");
    return int.Parse(Console.ReadLine());
}

int len = 12;
int lowVal = -9;
int hiVal = 9;

int number = Prompt("Введите число, которое будем икать в массиве");
int[] array = RndmArr(len, lowVal, hiVal);
Console.WriteLine($"Наш массив: ");
PrntArr(array);
Console.WriteLine();
if (IsFindNumb(array, number)) Console.WriteLine($"Введенное число {number} в есть массиве.");
else Console.WriteLine($"Введенное число {number} в массиве не найдено.");