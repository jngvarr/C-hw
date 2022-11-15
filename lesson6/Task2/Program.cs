// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со 
// сторонами такой длины.

int Prompt(string msg)
{
    Console.Write(msg + " >");
    return int.Parse(Console.ReadLine());
}

void Execute()
{
    int num1 = Prompt("Введите длину первой стороны треугольника");
    int num2 = Prompt("Введите длину второй стороны треугольника");
    int num3 = Prompt("Введите длину третьей стороны треугольника");
    if(IsItTriangle(num1,num2,num3)&&IsItTriangle(num2,num3,num1)&&IsItTriangle(num3,num2,num1))
    {
        Console.WriteLine("The triangle exists");
    }
    else Console.WriteLine("The triangle doesn`t exist");
}
Execute();

bool IsItTriangle(int x, int y, int z)
{
    return x + y > z;
}