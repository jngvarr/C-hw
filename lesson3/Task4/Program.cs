// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

 int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int N= Prompt("Введите число > ");
int count =1;
while (count<=N)
{
    System.Console.Write(" "+count*count);
    count++;
}
Console.WriteLine();
for (int i=1; i<=N; i++) {Console.Write(" "+ Math.Pow(i,2));}