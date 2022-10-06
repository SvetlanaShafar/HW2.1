Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99)
    Console.WriteLine($"Вторая цифра: {a = (a / 10) % 10}");
else 
Console.WriteLine("Введите трехзначное число!");
