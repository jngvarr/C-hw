// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать через функции.

int Prompt(string msg)
{
    Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

double degree(double a, double b)
{
    double aTmp = a;
    if (b == 0) return 1;
    if (b < 0) aTmp = 1 / a;
    {
        for (int i = 1; i < Math.Abs(b); i++)
        {
            a *= aTmp;
        }
    }
    double a = Prompt("ВВедите число А");
    double b = Prompt("ВВедите число B");
    degree(a, b);