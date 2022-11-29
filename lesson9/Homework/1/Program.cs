// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в 
//промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void EvenNum(int m, int n)
{
    if (m % 2 != 0) m++;
    if (m <= n)
    {
        Console.Write(m + " ");
        EvenNum(m + 2, n);
    }
}

int m = 1;
int n = 5;
int l = 4;
int k = 8;
EvenNum(m, n);
Console.WriteLine();
EvenNum(l, k);