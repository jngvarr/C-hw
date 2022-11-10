// Решение в группах задач:
// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string msg)
{
    Console.Write(msg + " >");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidNumb(int num)
{
    if (num >= 0) return true;
    else Console.WriteLine("Число должно быть не отрицательным"); return false;
}

int Fact(int num)
{
    int fact = 1;
    for (int i = 2; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}
int num = Prompt("Введите число");
if (ValidNumb(num))
{
    int fact = Fact(num);
    Console.WriteLine($"Факториал числа {num} равен {fact}");
}