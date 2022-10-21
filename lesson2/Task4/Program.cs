// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int Promt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

bool DivBy(int number)
{
    return (number % 7 == 0 && number % 23 == 0);
}

int number = Promt("Введите число");
if (DivBy(number)) Console.WriteLine($"Число {number} кратно 7 и 23");
else Console.WriteLine($"Число {number} не кратно 7 и 23");