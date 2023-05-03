// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// // 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int rev,
    sum = 0,
    t;
int num = Convert.ToInt32(Console.ReadLine());
reverseDigits(num);

void reverseDigits(int rev)
{
    if (num > 9999 && num < 100000)
    {
        for (t = num; num != 0; num = num / 10)
        {
            rev = num % 10;
            sum = sum * 10 + rev;
        }
        if (t == sum)
        {
            Console.Write("Число является палиндромом.");
        }
        else
        {
            Console.Write("Число не является палиндромом");
        }
    }
    else
    {
        Console.Write("Введите пятизначное число! ");
    }
}
