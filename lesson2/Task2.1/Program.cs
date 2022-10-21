﻿// 2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int number = new Random().Next(10, 9999);
Console.WriteLine(number);
int num = number;
int maxDigit = number % 10;
while (number > 0)
{
    int temp = number % 10;
    if (temp > maxDigit) { maxDigit = temp; }
    number = number / 10;
}
System.Console.WriteLine($"В чиселе {num} наибольшая цифра {maxDigit} ");