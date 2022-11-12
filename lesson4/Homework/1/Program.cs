// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать через функции.

int Prompt(string msg)
{
    Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void degree(int a, int b)
{
    int aTmp = a;
    for (int i = 1; i < b; i++)
    {
        a *= aTmp;
        Console.WriteLine(a + " ");
    }
    Console.Write($"Число {aTmp} в степени {b} равно: {a}");
}
int a = Prompt("Введите число А");
int b = Prompt("Введите число B");
degree(a, b);