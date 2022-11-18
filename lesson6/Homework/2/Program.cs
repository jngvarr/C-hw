// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int IntPrompt(string msg)
{
    Console.Write(msg + " _");
    return int.Parse(Console.ReadLine());
    Console.WriteLine();
}

double[] DotCalculate(int k1, int b1, int k2, int b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] coord = new double[2];
    coord[0] = x;
    coord[1] = y;
    return coord;
}

void Execute()
{
    int b1 = IntPrompt($"Введите значение K1:  >");
    int k1 = IntPrompt($"Введите значение B1:  >");
    int b2 = IntPrompt($"Введите значение K2:  >");
    int k2 = IntPrompt($"Введите значение B2:  >");
    double[] crossDot=DotCalculate(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения двух прямых ({crossDot[0]},{crossDot[1]})");
}
Execute();