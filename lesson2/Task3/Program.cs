// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Promt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int Divby(int a, int b)
{
    return b % a;
}

int number1 = Promt("ВВедите первое число: ");
int number2 = Promt("ВВедите второе число: ");

Console.WriteLine();
if (Divby(number1,number2) == 0) Console.WriteLine("Кратно");
else Console.WriteLine(Divby(number1,number2));