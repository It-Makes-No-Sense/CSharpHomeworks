// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// int getPow(int A,int B)
// {
//       int res = A;
//       if (B != 0)
//       {
//             for (int i = 1; i < B; i++)
//             {
//                   res = res * A;

//             }
//       }
//       else 
//       {
//             res = 1;
//       }
//       return(res);
// }

// Console.WriteLine("Введите число A");
// int A = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число B");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Число {A} возведенное в степень {B} = {getPow(A,B)}");

//Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int getNumberMembersSum(int num)
// {
//       int res = 0;
//       while (num/10 != 0)
//       {
//           res += num%10;
//           num = num/10;  
//       }
//       res += num;
//       return res;
// }

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{number} -> {getNumberMembersSum(number)}");

//Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] getArray(int size, int start, int end)
// {
//       int[] res = new int [size];
//       for (int i = 0; i < res.Length; i++)
//       {
//             res[i] = new Random().Next(start,end);
//       }
//       return res;
// }

// Console.WriteLine("Введите желаемую длину массива");
// int size = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите стратовое число диапазона");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите конечное число диапазона");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Ваш сгенерированный массив ->{String.Join(",",getArray(size,A,B))}");