// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int PromptInt(string msg)
{
    Console.Write(msg + " >");
    return Convert.ToInt32(Console.ReadLine());
}

int SummNumbers(int digit)
{
    if (digit <= 0)
    {
        return 0;
    }
    return digit % 10 + SummNumbers(digit / 10);
}

void Execute()
{
    int number = 123;//PromptInt("Введите начальное число диапазона чисел");
    Console.WriteLine();
    Console.Write($"Сумма цифр числа {number}= {SummNumbers(number)}.");
}
Execute();