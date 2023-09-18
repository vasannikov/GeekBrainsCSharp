﻿Console.WriteLine ("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()??"0");
a = (a%100)/10;
Console.WriteLine (a);
