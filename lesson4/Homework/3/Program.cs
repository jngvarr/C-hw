// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int Prompt(string msg)
{
    Console.Write(msg + "> ");
    return int.Parse(Console.ReadLine());
}

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

int qntty = Prompt($"Введите количество элементов массива ");
int lowVal = Prompt($"Введите минимальное значение элементов массива ");
int hiVal = Prompt("Введите максимальное значение элементов массива ");

Console.Write($"Массив из {qntty} элементов: ");
PrntArr(RndmArr(qntty, lowVal, hiVal));