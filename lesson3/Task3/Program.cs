// Задача 3: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

 int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int x1=Prompt("Введите координату Х для первой точки _");
int y1=Prompt("Введите координату Y для первой точки _");
int x2=Prompt("Введите координату Х для первой точки _");
int y2=Prompt("Введите координату Y для первой точки _");
double length =Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
System.Console.Write($"Расстояние между точками = {length:F2} ");