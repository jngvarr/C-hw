// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int Prompt(string msg)

{
    Console.Write(msg + ">");
    return int.Parse(Console.ReadLine());
}

int[] RandArray(int arg)
{
    int[] array = new int[arg];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-8, 0);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
}

(int, int) FindSecondMax(int[] array)
{
    int max = array[0], max2 = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max2 = max;
            max = array[i];
        }
        else if(max2==0) max2=array[i];
        else if (max2 <= array[i] && array[i] != max) max2 = array[i];
    }
    return (max, max2);
}

int qntty = Prompt("Введите количество случайных элементов массива ");
int[] arr = RandArray(qntty);
PrintArray(arr);
(int max, int max2) = FindSecondMax(arr);
Console.WriteLine();
Console.Write($"Максимальное число массива {max}, {max2} немного меньше");