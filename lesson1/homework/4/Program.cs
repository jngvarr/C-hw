//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число >");
int number = int.Parse(Console.ReadLine());

int count = 1;
Console.Write($"Четные числа от 1 до {number}: ");
while (count <= number)
{
    if (count % 2 == 0) Console.Write(count + " ");
    count++;
}