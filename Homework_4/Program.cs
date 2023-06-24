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

// int getCountChet(int[] array)
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
//       int countChet = getCountChet(array);
//       Console.Write($"{countChet}");
// }

// message();

