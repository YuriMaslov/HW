﻿//Напишите программу, которая на вход принимает число и выдает, является ли это число четным (делится ли оно на два без остатка)
//4 -> Да
//-3 -> Нет
// 7 -> Нет

Console.WriteLine("Введите число: ");
int a=int.Parse(Console.ReadLine());
if (a%2==0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");