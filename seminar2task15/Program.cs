﻿Console.WriteLine ("Введите порядковый номер дня недели, для того, чтобы программа определила, является ли этот день выходным: ");
int a = int.Parse(Console.ReadLine()??"0");
var weekend = new Dictionary<int, string>(){
    [1] = "нет",
    [2] = "нет",
    [3] = "нет",
    [4] = "нет",
    [5] = "нет",
    [6] = "да",
    [7] = "да",
};
string answer = weekend[a];
Console.WriteLine (answer);


