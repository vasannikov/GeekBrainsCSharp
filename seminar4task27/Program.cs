int Sum (int number, int[] digits){
    int result = 0;
    for (int i = 0; i < digits.Length; i++, number /= 10){
    digits[i] = number % 10;
    result += digits[i];
}  
    return result;
}

    Console.WriteLine ("Введите число:");
    int number = int.Parse(Console.ReadLine()??"0");
    int[] digits = new int[(int)Math.Log10(number) + 1]; 
    int answer = Sum(number, digits);
    Console.WriteLine("Результат работы приложения:");
    Console.WriteLine(answer);
