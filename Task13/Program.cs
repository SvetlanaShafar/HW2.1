Console.Clear();
Console.WriteLine("Введите любое число:");
int a = Convert.ToInt32(Console.ReadLine());
string m = Convert.ToString(a);
if (m.Length > 2)

Console.WriteLine($"Третья цифра: {m[2]}");


else

Console.WriteLine("Третьей цифры нет");
