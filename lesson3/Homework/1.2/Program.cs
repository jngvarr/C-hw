int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int Reverse(int number)
{
    int answer = 0;
    while(number > 0)
    {
        answer = answer * 10 + number %10;
        number = number / 10;
    }
    return answer;
}

bool CheckPalindrome(int num)
{
    return Reverse(num) == num;
}
int num = Prompt("Введите число > ");
if (CheckPalindrome(num)) Console.WriteLine("да");
else System.Console.Write("нет");