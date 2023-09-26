Console.WriteLine ("Введите число:");
int number = int.Parse(Console.ReadLine()??"0");
int[] digits = new int[(int)Math.Log10(number) + 1]; 
int result = 0;
for (int i = 0; i < digits.Length; i++, number /= 10){
    digits[i] = number % 10;
    result += digits[i];
}
Console.WriteLine("Результат работы приложения:");
Console.WriteLine(result);