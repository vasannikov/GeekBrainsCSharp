using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
      int n = Convert.ToInt32(N);
      for (int i=1;i<=n;i++){
        int k = i*i*i;
        Console.Write($"{k}\n");
      }  
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}