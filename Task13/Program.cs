// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Можно воспользоваться нумерацией строк, но необязательно)

Console.Clear();
Console.WriteLine("Введите любое число:");
double a = Convert.ToInt32(Console.ReadLine());
string m = Convert.ToString(a);
if (m.Length > 2)

Console.WriteLine($"Третья цифра: {m[2]}");


else

Console.WriteLine("Третьей цифры нет");
