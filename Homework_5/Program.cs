// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными(тип double) числами.

// double[,] getArray()
// {
//       Console.WriteLine("Введите кол-во строк массива");
//       int rows = int.Parse(Console.ReadLine()!);

//       Console.WriteLine("Введите кол-во столбцов массива");
//       int columns = int.Parse(Console.ReadLine()!);

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