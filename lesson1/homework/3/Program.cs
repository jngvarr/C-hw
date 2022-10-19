// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).


Console.WriteLine("Проверка числа на четность");
Console.Write("Введите число > ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Введенное число {number} - четное");
}
else Console.WriteLine($"Введенное число {number} - нечетное");