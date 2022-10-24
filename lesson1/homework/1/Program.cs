// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Поиск наибольшего из двух чисел");
Console.Write("Введите первое число > ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чиcло > ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"{number1} больше {number2}");
}
else
{
    Console.WriteLine(number2 + " больше " + number1);
}
