// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int IntPrompt(string msg)
{
    Console.Write(msg + " _");
    return int.Parse(Console.ReadLine());
    Console.WriteLine();
}

int[] CreateArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = IntPrompt($"Введите {i + 1}-е значение:  >");
    }
    return arr;
}

int CountPositiveNumb(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

void Execute()
{
    int[] arr = CreateArray(IntPrompt("Введите количество вводимых значений:"));
    PrintArray(arr);
    Console.Write($"Количество положительных введенных значений: ->{CountPositiveNumb(arr)}.");
}
Execute();