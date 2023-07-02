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

// int[,] getArray()
// {
//       int rows = new Random().Next(2,10);

//       int columns = new Random().Next(2,10);

//       Console.WriteLine($"m = {rows}, n = {columns}");

//       int[,] array = new int[rows,columns];

//       for (int i = 0; i < rows; i++)
//       {
//             for (int j = 0; j < columns; j++)
//             {
//                   array[i,j] = new Random().Next(1,10);
//             }
//       }
//       return array;
// }

// void PrintArray(int[,] array)
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

// void checkIndex(int[,] array)
// {
//       Console.WriteLine("Введите индекс строки в массиве: ");
//       int row = int.Parse(Console.ReadLine()!);

//       Console.WriteLine("Введите индекс столбца в массиве: ");
//       int column = int.Parse(Console.ReadLine()!);
      
//       if (row < array.GetLength(0) && column < array.GetLength(1))
//       {
//             Console.WriteLine($"array[{row},{column}] ---> {array[row,column]}");
//       }
//       else 
//       {
//             Console.WriteLine("Такого элемента нет в массиве!");
//       }
// }

// int[,] array = getArray();
// PrintArray(array);
// checkIndex(array);

