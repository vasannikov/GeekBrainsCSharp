Console.WriteLine ("Введите первое число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ("Введите второе число");
int b = int.Parse(Console.ReadLine()??"0");
if (a > b){
    Console.WriteLine (a);
}else{
    Console.WriteLine (b);
}
