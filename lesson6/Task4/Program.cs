// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string msg)
{
    Console.Write(msg + "_");
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.WriteLine();
}

int[] Fibonacci(int num)
{
    if (num < 2) num=2;
        int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

int[] arr1 = Fibonacci(Prompt("Введите длину первого массива"));
int[] arr2 = Fibonacci(Prompt("Введите длину первого массива"));
int[] arr3 = Fibonacci(Prompt("Введите длину первого массива"));

PrintArray(arr1);
PrintArray(arr2);
PrintArray(arr3);
