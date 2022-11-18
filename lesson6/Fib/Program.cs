// Задача 3: используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
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
    if (num == 1 || num == 2)
    {
        Console.Write($"{1}");
        return 1;
    }

    else
    {
        int f = Fibonacci(num - 1) + Fibonacci(num - 2);
        Console.Write($"{f}");
        return f;
    }
}

int[] arr1 = Fibonacci(Prompt("Введите длину первого массива"));
int[] arr2 = Fibonacci(Prompt("Введите длину первого массива"));
int[] arr3 = Fibonacci(Prompt("Введите длину первого массива"));

PrintArray(arr1);
PrintArray(arr2);
PrintArray(arr3);
