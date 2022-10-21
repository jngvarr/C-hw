// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

int number = new Random().Next(100, 999);
Console.WriteLine($"Случайное число: {number}");

string firstDigit = Convert.ToString(number / 100); // вроде не для для рассчета строки, а для вывода
string lastDigit = Convert.ToString(number % 10);

Console.WriteLine(firstDigit + lastDigit);
// либо, если надо int: 
//int withoutMiddleDigit=Convert.ToInt32(firstDigit+lastDigit);
//Console.WriteLine(withoutMiddleDigit);

//если все-таки много строк, то тогда так (смысл тот же):
// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int withoutMiddleDigit = firstDigit * 10 + lastDigit;
// Console.WriteLine(withoutMiddleDigit);