// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

int number = new Random().Next(100, 999);
Console.WriteLine($"Случайное число: {number}");

string firstDigit = Convert.ToString(number / 100);
string lastDigit = Convert.ToString(number % 10);

Console.WriteLine(firstDigit+lastDigit);