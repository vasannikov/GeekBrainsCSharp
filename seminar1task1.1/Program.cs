Console.WriteLine("Введите число: ");
string? inputNum = Console.ReadLine();
if(inputNum != null){
    long num = long.Parse(inputNum);
    long res = num*num;
    Console.WriteLine(res);
}