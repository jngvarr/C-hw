// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5


String OutputNumb(int numb)
{
    int sum = 0;
    int j = 0;
    if (numb == 1)
    {
        Console.Write("1");
    }
    else
    {
        for (int i = 1; sum < numb; i++)
        {
            sum += i;
            j = i;
        }
        Console.Write(OutputNumb(--numb) + " " + j);
    }
    return "";
}

OutputNumb(12);
