using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      string x = Convert.ToString(number);
      int len = x.Length;
      if (len == 5){
        if (x[0] == x[4] && x[1] == x[3]){
            return true;
            }else{
                return false;
                }
                }else{
                    Console.WriteLine ("Число не пятизначное");
                    return false;
                    }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}