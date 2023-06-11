// Задание №1
// Console.WriteLine("Задание 1");


// Console.WriteLine("Введите Первое Число");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Второе Число");
// int y = Convert.ToInt32(Console.ReadLine());

// int min;
// int max;

// if (y>x)
// {
//       max = y;
//       min = x;
// }

// else
// {
//       max = x;
//       min = y;
// }
// Console.Write($"{max} большее число,а {min} меньшее");

// Задание 2
Console.WriteLine("Задание 2");

Console.WriteLine("Введите Первое Число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Второе Число");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Третье Число");
int z = Convert.ToInt32(Console.ReadLine());

int min;
int max;

if (y>x)
{
      if (x>z)
      {
            max = y;
            min = z;
      }
      else
      {
            min = x;
            if (y>z)
            {
                  max = y;
            }
            else
            {
                  max = z;
            }
      }
}
else
{
      if (y>z)
      {
            max = x;
            min = z;
      }
      else
      {
            min = y;
            if (x>z)
            {
                  max = x;
            }
            else
            {
                  max = z;
            }
      }
}


Console.Write($"{max} большее число,а {min} меньшее");