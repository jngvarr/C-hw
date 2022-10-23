// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

bool ValidInput(int num)
{
    if (num < 10000 || num > 99999) 
    {
    Console.WriteLine("Введенные данные не соответствуют условию. ");
    return false;
    }
    else return true;
}
void ResultOutput(int num)
{
    if (num % 10 == num / 10000 && (num / 1000 % 10 == num / 10 % 10)) Console.Write($"Введенное число {num} - палиндром.");
    else Console.Write("Введено обычное пятизначное число");
}
int num = Prompt("Введите пятизначное число: ");
if (ValidInput(num)) ResultOutput(num);
else Console.WriteLine("Попробуйте еще раз.");