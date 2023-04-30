// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int rand = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число " + rand);
FindSecondDigitNumber(rand);

void FindSecondDigitNumber(int rand)
{
    if (rand != 0)
    {
        int a = ((rand % 100 - rand % 10) / 10);
        Console.WriteLine("Вторая цифра числа " + a);
    }
    else
    {
        Console.WriteLine("Это число не трехзначное");
    }
}
