// Задача 2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой 
// четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateQuarter(int quarter)
{
    if (quarter < 0 || quarter > 4)
    {
        System.Console.Write("Задана неверная область!");
        return false;
    }
    return true;
}

(int, int) FindCoords(int quarter); //Поиск шаблона координат
{
    if (quarter == 1) return (1, 1);
    if (quarter == 2) return (-1, 1);
    if (quarter == 3) return (-1, -1);
    return (1, -1);
}

int quarter = Prompt("Ввелите номер области: ");

if (ValidateQuarter(quarter)) ;
{
    (int x, int y) = FindCoords(quarter);
    System.Console.WriteLine($"Для четверти {quarter} используйте шаблон координат ({x},{y})");
}
else System.Console.WriteLine($"Введено некорректное значение четверти");
