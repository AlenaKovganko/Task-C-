﻿//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b) Console.WriteLine ("Да, является");
else Console.WriteLine ("Нет, не является");
