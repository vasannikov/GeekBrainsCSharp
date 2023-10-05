﻿using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++){
                Console.Write(matrix[i, j] + "\t");
            }
        Console.WriteLine("");
    }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
        int[, ] matrix=new int[n, m];
        int x = 1;
        for (int i = 0; i < n; i++){
            Console.WriteLine();
            for (int j = 0; j < m; j++){
                matrix[i, j] = x;
                x += k;
            }
        }
        return matrix;
    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
        int matrix_rowPosition = matrix.GetLength(0);
        int matrix_columnPosition = matrix.GetLength(1);
        int[] results = new int[2];
        if (rowPosition >= matrix_rowPosition && columnPosition >= matrix_columnPosition){
            results[0] = 0;
            results[1] = 0;
        }
        if (columnPosition < matrix_columnPosition && rowPosition < matrix_rowPosition){
            results[0] = matrix[rowPosition-1, columnPosition-1];
            results[1] = 0;
        }
        return results;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
        if (results[0]!=0 && results[1]==0){
            Console.WriteLine("The number in [" + Y + ", " + X + "] is " + results[0]);
        }
        if (results[0]==0 && results[1]==0){
            Console.WriteLine("There is no such index");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}