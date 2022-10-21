// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
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

int number = Prompt("ВВедите трехзначное число: ");

if (ValidateNumber(number))
    {
    int lastDigit = number / 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {lastDigit}"); 
    }