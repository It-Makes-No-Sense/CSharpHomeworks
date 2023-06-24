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
//       int countEven = getCountEven(array);
//       Console.Write($"{String.Join(',',array)} --> {countEven}");
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

// int getSum(int[] array)
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
//       int sum = getSum(array);
//       Console.Write($"{String.Join(',',array)} --> {sum}");
// }

// message();

// Задача 38: Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// int[] getArray(int size)
// {
//       int[] array = new int[size];
//       for (int i = 0; i < array.Length; i++)
//       {
//             array[i] = new Random().Next(10,99);
//       }
//       return array;
// }

// int getMax(int[] array)
// {
//       int max = array[0];
//       for (int i = 1; i < array.Length; i++)
//       {
//             if (array[i] > max)
//             {
//                   max = array[i];
//             }
//       }
//       return max;
// }

// int getMin(int[] array)
// {
//       int min = array[0];
//       for (int i = 1; i < array.Length; i++)
//       {
//             if (array[i] < min)
//             {
//                   min = array[i];
//             }
//       }
//       return min;
// }

// int getDifference(int max,int min)
// {
//       int dif = max - min;
//       return dif;
// }

// void message()
// {
//       int[] array = getArray(6);
//       int max = getMax(array);
//       int min = getMin(array);
//       int dif = getDifference(max,min);
//       Console.Write($"{String.Join(",",array)} --> {max}-{min} = {dif}");
// }

// message();