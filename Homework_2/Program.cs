// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом

string palindrom(string s)
{
      string res;
      if (s[0]==s[4] && s[1]==s[3])
      {
            res = "Да";
      }
      else 
      {
            res = "Нет";
      }
      return res;
}

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;

if (number.Length != 5)
{
      Console.WriteLine("Это не пятизначное число!");
}
else
{
      string result = palindrom(number);
      Console.WriteLine($"Является ли число {number} палиндромом? \nОтвет:{result}");
}