// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray(int length=8)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(0, 2);
    }
    return tempArray;
}

void PrintArray(int[] arr)
{
    Console.Write (arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write ($", {arr[i]}");
    }
}
Console.Write("Mассив из 8 элементов, заполненный нулями и единицами в случайном порядке: ");
PrintArray(CreateArray());