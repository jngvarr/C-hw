// 4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа
// предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int quantity = Prompt($"Введите количество случайных чисел: ");
int count = 0;
int multiplicity = Prompt("На кратность какому числу будем проверять эти числа? Введите число: ");
while (count < quantity)
{
    int number = new Random().Next(1, 100);

    if (number % multiplicity == 0)
    {
        Console.Write($"Случайное число {number} кратно числу {multiplicity}. Закругляемся...");
        break;
    }
    else 
    {
        Console.WriteLine($"Случайное число {number} не кратно числу {multiplicity}. Идём дальше...");
        count++;
    }
}