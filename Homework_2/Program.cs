// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом

// string palindrom(string s)
// {
//       string res;
//       if (s[0]==s[4] && s[1]==s[3])
//       {
//             res = "Да";
//       }
//       else 
//       {
//             res = "Нет";
//       }
//       return res;
// }

// Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine()!;

// if (number.Length != 5)
// {
//       Console.WriteLine("Это не пятизначное число!");
// }
// else
// {
//       string result = palindrom(number);
//       Console.WriteLine($"Является ли число {number} палиндромом? \nОтвет:{result}");
// }




// Задача 21
// Напишите программу,которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координату X для точки A");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y для точки A");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z для точки A");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X для точки B");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y для точки B");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z для точки B");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double res = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
// Console.WriteLine($"Расстояние между AB в 3D пространстве = {res}");




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int qube;

// Console.Write($"{num} -> ");
// for (int i= 1; i<=num;i++)
// {
//       qube = Convert.ToInt32(Math.Pow(i,3));
//       if (i<num)
//       {
//             Console.Write($"{qube}, ");
//       }
//       else
//       {
//             Console.Write($"{qube}");
//       }
// }