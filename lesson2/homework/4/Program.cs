// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
int number=Prompt("Введите цифру дня недели");
if(number==6||number==7) Console.Write("Выходной");
else Console.Write("Рабочий день");