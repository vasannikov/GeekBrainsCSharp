int Calculator(int number1, int number2, int operation){
    int result = 1;
    switch (operation){
        case 1: result = number1+number2; break;
        case 2: result = number1-number2; break;
        case 3: result = number1/number2; break;
        case 4: result = number1*number2; break;
        case 5:
    for (int i=0; i<number2; i++){
        result = result*number1;
    }
    break;
}
    return result;
}

    Console.WriteLine("Вас приветствует калькулятор!\n Введите два числа над которыми необходимо выполнить операцию:");
    int number1 = int.Parse(Console.ReadLine()??"0");
    int number2 = int.Parse(Console.ReadLine()??"0");
    int operation = 0;
    Console.WriteLine("Выберите операцию, которую необходимо провести над числами:\n 1 - сложение \n 2 - вычитание \n 3 - деление \n 4 - умножение \n 5 - возведение первого числа в степень второго \n");
    operation = int.Parse(Console.ReadLine()??"0");
    int answer = Calculator(number1, number2, operation);
    Console.WriteLine("Результат операции:");
    Console.WriteLine(answer);

