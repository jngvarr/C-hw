// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int PromptInt(string msg)
// {
//     Console.Write(msg + " >");
//     return Convert.ToInt32(Console.ReadLine());
// }

void NaturalOutput(int lastNum)
{
    while (lastNum != 0)
    {
        Console.Write(lastNum + " ");
        NaturalOutput(lastNum - 1);
        Console.Write(lastNum + " ");
        break;
    }

}

void Execute()
{
    int lastNumber = 7;//PromptInt("Введите начальное число диапазона чисел");
    NaturalOutput(lastNumber);
}
Execute();