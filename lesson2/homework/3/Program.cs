// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета.

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
int number = Prompt("Введите число: ");
if (number / 100 > 0)
{
    number /= 100;
    Console.WriteLine($"В третьей позиции число {number % 10}");
}
else Console.WriteLine("введенное число меньше 100");