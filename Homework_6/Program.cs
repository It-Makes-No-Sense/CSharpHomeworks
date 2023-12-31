﻿// Задача 54: Задайте двумерный массив. 
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



// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

// void diction(int[,] array)
// {
//       int rows = array.GetLength(0);
//       int columns = array.GetLength(1);

//       var diction = new Dictionary<int, int>();
//       for (int i = 0; i < rows; i++)
//       {
//             for (int j = 0; j < columns; j++)
//             {
//                   if (!diction.ContainsKey(array[i,j]))
//                   {
//                         diction.Add(array[i,j],1);
//                   }
//                   else
//                   {
//                         diction[array[i,j]] += 1;
//                   }
//             }
//       }
//       foreach (var d in diction)
//       {
//             Console.WriteLine($"{d.Key} встречается {d.Value} раз");
//       }
// }

// int[,] array = getArray();
// printArray(array);
// diction(array);



// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// int[,] getArray()
// {
//       int rows = 2;

//       int columns = 2;

//       Console.WriteLine($"m = {rows}, n = {columns}");

//       int[,] array = new int[rows,columns];

//       for (int i = 0; i < rows; i++)
//       {
//             for (int j = 0; j < columns; j++)
//             {
//                   array[i,j] = new Random().Next(2,5);
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

// int[,] getM(int[,] array,int[,] sec_array)
// {
//       int[,] res = new int[array.GetLength(0),array.GetLength(1)];
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//             for (int j = 0; j < sec_array.GetLength(0); j++)
//             {
//                   for (int k = 0; k < sec_array.GetLength(1); k++)
//                   {
//                         res[i,j] += array[i,k] * sec_array[k,j];
//                   }
//             }
//       }

//       return res;
// }

// int [,] array = getArray();
// printArray(array);
// Console.WriteLine("------");
// int [,] sec_array = getArray();
// printArray(sec_array);
// Console.WriteLine("--result----");
// int [,] res = getM(array,sec_array);
// printArray(res);