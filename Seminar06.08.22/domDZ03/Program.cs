﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Вводим число");
double n = double.Parse(Console.ReadLine());

int count = 1;
while (count <= n)
{
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
