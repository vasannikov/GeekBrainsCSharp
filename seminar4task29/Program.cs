Console.WriteLine("Данное приложение может сгенерировать массив из 8 случайных чисел или принять написанные вами 8 значений.\nЕсли вы хотите ввести значения вручную, выберите 1, иначе - 2:");
int choice = int.Parse(Console.ReadLine()??"0");
Random rnd = new Random();
if (choice==1){
    string[] array = new string[8];
    for(int i=0; i<8; i++){
        array[i] = Console.ReadLine();
        }
    for(int i=0; i<8; i++){
        Console.WriteLine(array[i]);
        }
}
if (choice==2){
    int[] array = new int[8];
    for(int i=0; i<8; i++){
        array[i] = rnd.Next(500);
        }
    for(int i=0; i<8; i++){
        Console.WriteLine(array[i]);
        }
}