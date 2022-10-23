// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов в диапазоне от 1 до 10, 
// и подсчитывает, сколько сгенерировалось чисел больше 5.

int[] GetArray(int length) // функция заполнения массива
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
    return numbers;
}

int GetCount(int[] arr)// функция подсчета элементов >5
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 5)
        {
            count++;
        }
    }
    return count;
}
void PrintDatas(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
}


int[] array = GetArray(10);
PrintDatas(array);
Console.WriteLine();
// int count = 0;
// for (int i = 1; i <= 10; i++)
// {
//     int number = new Random().Next(1, 10);
//     if (number > 5) count++;
// }
Console.WriteLine($"{GetCount(array)} элементов последовательности больше 5");