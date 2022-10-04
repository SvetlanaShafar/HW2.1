Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра: {a=(a/10) % 10}");
