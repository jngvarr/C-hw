// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 99);

int firstDigit = number % 10;
int secondDigit = number / 10;
//int max = firstDigit;
//if (secondDigit > max) max = secondDigit;

int DigitCompare(int num1, int num2)
{
    if (num1 > num2) ;
    {
        return num1;
    }
    return num2;
}
int max=DigitCompare(firstDigit, secondDigit);
System.Console.WriteLine($"Число {max} наибольшее из двух случайных чисел {firstDigit} и {secondDigit}");