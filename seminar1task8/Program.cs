Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine()??"0");
int b = 2;
while (b<a){
    Console.WriteLine ($"{b}, ");
    b = b+2;
}

