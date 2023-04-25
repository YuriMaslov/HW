// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
// 2,3,7 ->7
// 44,5,78 ->78
// 22,3,9 ->22

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
if (a > b)
{
  Console.WriteLine("Максимальное число: " +  a);    
}
else if (c > a)
{
  Console.WriteLine("Максимальное число: " +  c);    
}
else 
{
     Console.WriteLine("Эти числа одинаковые!!!");
}