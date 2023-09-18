Console.WriteLine ("Введите первое число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ("Введите второе число");
int b = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ("Введите третье число");
int c = int.Parse(Console.ReadLine()??"0");
int max = 0;
if (a > b && a>c){
    max = a;
}
if (b>a && b>c){
    max = b;
}
if (c>a && c>b){
    max = c;
}
Console.WriteLine ("Наибольшее число: ");
Console.WriteLine (max);


