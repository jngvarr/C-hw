// Задача 6*: Напишите программу, которая генерирует последовательность случайных чисел (1-10) до тех пор, 
// пока не сгенерирует кратное число введенному в начале.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Starter()
{
    int number = Prompt("Введите число от 1 до 10 > ");
    while (true)
    {
        int num = new Random().Next(1, 10);
        if (num % number == 0)
        {
            Console.Write($"Нашли кратное {num} число. Это число {number}.");
            break;
        }
        Console.WriteLine($"Пока не получилось, случайное число = {num}.");
    }
}

Starter();