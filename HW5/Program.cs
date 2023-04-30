// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next(10, 1000);
Console.WriteLine("Рандомное число " + number);
FindThirdNumber(number);

void FindThirdNumber(int a)
{
    if (a >= 100 && a < 1000)
    {
        Console.Write("Последня цифра: " + number % 10);
    }
    else
    {
        Console.Write("Третьей цифры нет ");
    }
}
