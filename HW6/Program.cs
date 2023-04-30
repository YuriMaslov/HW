// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);
Dayoff(number);

void Dayoff(int a)
{
    int day = 0;
    if (a >= 1 && a <= 5)
    {
        Console.WriteLine("Увы, до выходного еще далеко! ");
    }
    else
    {
        Console.WriteLine("Ура, выходной");
    }
}
