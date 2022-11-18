//Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] RandomArray(int len = 10, int min = 0, int max = 999)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"{arr[0]}, ");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

// int Prompt(string msg)
// {
//     Console.Write(msg + " _");
//     return int.Parse(Console.ReadLine());
// }

int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

void Runner()
{
    int[] arr = RandomArray(7);
    // int[] copyArr = new int[];
    int[] copyArr = arr;
    PrintArray(arr);
    Console.WriteLine();
    copyArr[0] = 777;
    PrintArray(arr);
    Console.WriteLine();
    PrintArray(copyArr);
    Console.WriteLine();
    int[] copyArr2 = CopyArray(arr);
    arr[1] = 1000;

    PrintArray (arr);
    Console.WriteLine();
    PrintArray (copyArr2);

}
Runner();