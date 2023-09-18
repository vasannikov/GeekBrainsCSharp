﻿Console.WriteLine ("Введите число: ");
long a = int.Parse(Console.ReadLine()??"0");
if (a > 99){
    while (a > 1000){
        a /= 10;
    }
    Console.WriteLine (a%10);
}else{
    Console.WriteLine ("Третьей цифры нет!");
}

