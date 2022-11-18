//Написать последовательность n...1 при помощи рекурсии

int Prompt(string msg)
{
    Console.Write(msg + "_");
    return int.Parse(Console.ReadLine());
}

void Seq(int n)
{
    if (n <= 0) return;
     Seq(n - 1);
    Console.Write(n + " ");
   
}
Seq(Prompt("ВВедите число: "));