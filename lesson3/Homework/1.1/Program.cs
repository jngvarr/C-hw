int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}
bool IsPal(int num)
{
    int x1 = num;
    int x2 = 0;
    while (x1 / 1 > 0)
    {
        x2 = x2 * 10 + x1 % 10;
        x1 = x1 / 10;
    }
    return num == x2;
}

int num = Prompt("Введите число >");
if (IsPal(num)) Console.WriteLine("Палиндром");
else Console.WriteLine("не Палиндром");