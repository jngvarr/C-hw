// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

bool ValidNumb(int num)
{
    if (num <= 0)
    {
        Console.WriteLine("Число должно быть положительным");
        return false;
    }
    return true;
}

int SumNumb(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int SumGauss(int num)
{
    return (int) (num / 2.0 * (1 + num));
}
int num = Prompt("Введите число");
if (ValidNumb(num))
{
    int sum = SumNumb(num);
    int sumGauss = SumGauss(num);
    Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}, а Гаусс говорит, что {sumGauss}");
}