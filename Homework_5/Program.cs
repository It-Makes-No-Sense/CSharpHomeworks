// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными(тип double) числами.

// double[,] getArray()
// {
//       int rows = new Random().Next(1,7);

//       int columns = new Random().Next(1,7);

//       Console.WriteLine($"m = {rows}, n = {columns}");

//       double[,] array = new double[rows,columns];

//       for (int i = 0; i < rows; i++)
//       {
//             for (int j = 0; j < columns; j++)
//             {
//                   array[i,j] = Math.Round(new Random().NextDouble(),2);
//             }
//       }
//       return array;
// }

// void PrintArray(double[,] array)
// {
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                   Console.Write($"{array[i,j]} ");
//             }
//             Console.WriteLine();
//       }
// }

// double[,] array = getArray();
// PrintArray(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

