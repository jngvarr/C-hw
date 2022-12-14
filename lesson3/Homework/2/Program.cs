// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите координату Х для первой точки >");
int y1 = Prompt("Введите координату Y для первой точки >");
int z1 = Prompt("Введите координату Z для первой точки >");
int x2 = Prompt("Введите координату Х для второй точки >");
int y2 = Prompt("Введите координату Y для второй точки >");
int z2 = Prompt("Введите координату Z для второй точки >");
double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
System.Console.Write($"Расстояние между точками = {length:F2} ");