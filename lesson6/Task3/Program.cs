// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string msg)
{
    Console.Write(msg + "_");
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

int[] DectoBinConverter(int num)
{
    int[] binArr = new int[num];
    int i = binArr.Length - 1;
    while (num > 0)
    {
        binArr[i] = num % 2;
        num /= 2;
        i--;
    }
    return binArr;
}

int[] arr = DectoBinConverter(Prompt("Введите десятичное число: "));
PrintArray(arr);
