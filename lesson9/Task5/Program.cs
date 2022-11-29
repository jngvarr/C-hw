// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

bool DivbByTwo(int n)
{
    if (n == 2 || n == 1) return true;
    return (n % 2 == 0 && DivbByTwo(n / 2));
}

int n = 16;
if (DivbByTwo(n)) Console.WriteLine("Степень двойки");
else Console.WriteLine("Не степень двойки");