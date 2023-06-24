// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] getArray(int size)
// {
//       int[] array = new int[size];
//       for (int i = 0; i < array.Length; i++)
//       {
//             array[i] = new Random().Next(100,999);
//       }
//       return array;
// }

// int getCountEven(int[] array)
// {
//       int count = 0;
//       for (int i = 0; i < array.Length; i++)
//       {
//             if (array[i] % 2 == 0)
//             {
//                   count++;
//             }
//       }
//       return count;
// }

// void message()
// {
//       int[] array = getArray(5);
//       Console.Write($"{String.Join(',',array)} --> ");
//       int countEven = getCountEven(array);
//       Console.Write($"{countEven}");
// }

// message();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.

// int[] getArray(int size)
// {
//       int[] array = new int[size];
//       for (int i = 0; i < array.Length; i++)
//       {
//             array[i] = new Random().Next(0,1000);
//       }
//       return array;
// }

// int getSumUnevenIndexesInArray(int[] array)
// {
//       int sum = 0;
//       for (int i = 0; i < array.Length; i++)
//       {
//             if (i % 2 != 0)
//             {
//                   sum += array[i];
//             }
//       }
//       return sum;
// }

// void message()
// {
//       int[] array = getArray(6);
//       Console.Write($"{String.Join(',',array)} --> ");
//       int sum = getSumUnevenIndexesInArray(array);
//       Console.Write($"{sum}");

// }

// message();