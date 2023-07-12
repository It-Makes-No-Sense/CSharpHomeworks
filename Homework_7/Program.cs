// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// int getNumber()
// {
//       Console.WriteLine("Введите число:");
//       int number = int.Parse(Console.ReadLine()!);
//       return number;
// }

// void printNatNum(int num)
// {     
//       if (num == 1)
//       {
//             Console.Write($"{num}");
//       }
//       else
//       {
//             Console.Write($"{num},");
//             printNatNum(num-1);
//       }
// }

// int number = getNumber();
// printNatNum(number);


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// int getNumber()
// {
//       Console.WriteLine("Введите число:");
//       int number = int.Parse(Console.ReadLine()!);
//       return number;
// }

// int getSum(int N, int M)
// {
//       int sum = N;
//       if (N<M)
//       {
//             sum += getSum(N+1,M);
//       }  
//       return(sum);
// }

// int N = getNumber();
// int M = getNumber();
// Console.WriteLine($"{N},{M} --> {getSum(N,M)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.

// int getNumber()
// {
//       Console.WriteLine("Введите число:");
//       int number = int.Parse(Console.ReadLine()!);
//       return number;
// }

// int ackerman(int N, int M)
// {
//       if (N == 0)
//       {
//             return M+1;
//       }
//       else if (M == 0)
//       {
//             return ackerman(N-1,1);
//       }
//       else 
//       {
//             return ackerman(N -1,ackerman(N,M-1));
//       }
// }

// int N = getNumber();
// int M = getNumber();
// Console.WriteLine($"N={N},M={M} --> {ackerman(N,M)}");