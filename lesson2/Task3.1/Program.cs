// 3.1. Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int index = 0;
int[] array = new int[5];
double sum = 0;
while (index < 5)
{
    array[index] = Prompt($"Введите {index + 1}-е число: ");
    sum = sum + array[index];
    index++;
}
Console.WriteLine($"Сумма введенных чисел равна: {sum}");
Console.WriteLine($"Среднее арифметическое введенных чисел равно: {sum / array.Length}");