// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число a: ");
string a_String = Console.ReadLine();
double a1 = Convert.ToInt32(a_String);
double a3 = Math.Truncate(a1 /10);
double a2 = a3 % 10;
Console.Write(a2);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число a: ");
string Number = Console.ReadLine();
char [] ch = Number.ToCharArray();
if (ch.Length > 2)
{
  char c = Number[2];
  Console.WriteLine(c);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) 
{
    txtResult = $". Этот день недели - выходной!";
}
else txtResult = $", рабочий день недели.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();


