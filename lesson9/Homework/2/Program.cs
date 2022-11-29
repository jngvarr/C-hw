// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int EvenNum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + EvenNum(m + 1, n);
}

int m = 1;
int n = 15;
int l = 4;
int k = 8;

Console.WriteLine(EvenNum(m, n));
Console.WriteLine(EvenNum(l, k));