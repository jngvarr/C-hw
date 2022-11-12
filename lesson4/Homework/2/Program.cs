// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.

int Prompt(string msg)
{
    Console.Write(msg + " >");
    return int.Parse(Console.ReadLine());
}

int SumDgt(int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
int a = Prompt("Введите число ");
Console.Write($"Cумма цифр числа {a} равна {SumDgt(a)}");