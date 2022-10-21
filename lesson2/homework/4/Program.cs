// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Ошибка ввода числа");
        return false;
    }
    return true;
}

int number = Prompt("Введите цифру дня недели: ");
if (ValidateNumber(number))
{
    if (number == 6 || number == 7) Console.Write("Выходной");
    else Console.Write("Рабочий день");
}