Console.Clear();
Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int ost = 0;
int c = a;

while (a < 10000 || a > 99999)
{
    Console.WriteLine("Введите пятизначное число");
     a = Convert.ToInt32(Console.ReadLine());
}
if (a % 10 == 0)
    Console.WriteLine("Число не палиндром");
else
{
    while (a > 0)
    {
        ost = a % 10;
        b = b * 10 + ost;
        a = a / 10;
    }

    if (c == b)
        Console.WriteLine("Число палиндром");
    else
        Console.WriteLine("Число не палиндром");

}

