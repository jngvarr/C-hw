// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

void OutputNumb(int numb)
{
    int limit = 0;
    
    for (int i = 1; i <= numb; i++)
    { 
        limit++;
        if (limit == 12) break;
        Console.Write(numb + " ");
       
       
        if (i == numb) OutputNumb(numb + 1);
    }
}

OutputNumb(12);