// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B 
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PromptInt(string msg)
{
    Console.Write(msg + " >");
    return Convert.ToInt32(Console.ReadLine());
}

int Exp(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a * Exp(a, b - 1);
}

void Execute()
{
    int a = PromptInt("Введите число A");
    int b = PromptInt("Введите число B");

    Console.Write(Exp(a, b));
}
Execute();