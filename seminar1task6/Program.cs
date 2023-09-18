Console.WriteLine ("Введите число, которое необходимо проверить на чётность: ");
int a = int.Parse(Console.ReadLine()??"0");
if (a%2 == 0){
    Console.WriteLine ("Число является чётным");
}else{
    Console.WriteLine ("Число является нечётным");
}

