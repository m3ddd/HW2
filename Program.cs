// // Задача 10: 
// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Translation (string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

int number = Translation("Введите трехзначное число: ");
if (number > 100 && number <= 1000)
{
  int secondRank = number / 10 % 10;
Console.WriteLine($"Вы ввешли число: {number}" );
Console.WriteLine($"Вторая цифра: {secondRank}");
}
else
Console.WriteLine("Вы ввели не трехзначное число, повторите попытку снова");
c