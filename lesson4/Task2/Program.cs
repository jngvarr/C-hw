// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string msg)
{
    Console.Write(msg + " >");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidNumb(int num)
{
    if (num > 0) return true;
    else Console.WriteLine("Число должно быть положительным"); return false;
}

int DigitQtty(int num)
{
    int qtty = 0;
    while (num > 0)
    {
        num /= 10;
        qtty++;
    }
    return qtty;
}
int num = Prompt("Введите число");
if (ValidNumb(num))
{
    int qtty = DigitQtty(num);
    Console.WriteLine($"Количество цифр в введенном числе {num} равно {qtty}");
}