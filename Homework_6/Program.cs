// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// void printArray(int[,] array)
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

// int[,] reconstruct(int[,] array)
// {
//       int num = 0;
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                   int column = j;
//                   while (column!=0)
//                   {
//                         if (array[i,column]>array[i,column-1])
//                         {
//                               num = array[i,column-1];
//                               array[i,column-1] = array[i,column];
//                               array[i,column] = num;  
//                         }
//                         column--;
//                   }
//             }
//       }
//       return array;
// }

// int [,] array = getArray();
// printArray(array);
// Console.WriteLine("------------");
// array = reconstruct(array);
// printArray(array);