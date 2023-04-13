// // Задача 10: 
// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int Translation (string message)
// {
//   Console.Write(message);
//   return Convert.ToInt32(Console.ReadLine());
// }

// int number = Translation("Введите трехзначное число: ");
// if (number > 100 && number <= 1000)
// {
//   int secondRank = number / 10 % 10;
// Console.WriteLine($"Вы ввешли число: {number}" );
// Console.WriteLine($"Вторая цифра: {secondRank}");
// }
// else
// Console.WriteLine("Вы ввели не трехзначное число, повторите попытку снова");


// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// int ThirdDigit (int number)
// {
//   int result = -1;
//   if (number >= 100)
//   {
//       while(number > 999)
//       {
//          number = number / 10;
//       }
//       result = number % 10;
//   }
//   return result;
// }
// Console.Write("Введите ваше число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (ThirdDigit(number1) == -1)
// Console.WriteLine("Третьей цифры нет =(");
// else
// Console.WriteLine($"Вы ввели число: {number1}");
// Console.WriteLine($"Третя цифра этого числа: {ThirdDigit(number1)}");