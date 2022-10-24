// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Определение максимального из трех чисел");
Console.Write("Введите первое число > ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число > ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число > ");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"{number1} максимальное из чисел {number1}, {number2}, {number3}");
}
else if (number2 > number3 && number2 > number1)
{
    Console.WriteLine($"{number2} максимальное из чисел {number1}, {number2}, {number3}");
}
else
{
    Console.WriteLine($"{number3} максимальное из чисел {number1}, {number2}, {number3}");
}