// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

int Prompt(string message) // ввод с клавиатуры
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100 || number >= 1000)
    {
        System.Console.WriteLine("Это число не трехзначное");
        return false;
    }
    return true;
}
link1: int number = Prompt("Введите трехзначное число: ");
if (ValidateNumber(number))
{
    int midleDigit = number / 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {midleDigit % 10}");
}
else goto link1;
