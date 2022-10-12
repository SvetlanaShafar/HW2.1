Console.Clear();
Console.WriteLine("Введите  число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
if (a < 0)
    a = a * (-1);
while (a > 0)
{

    int c = a % 10;
    b = b + c;
    a = a / 10;
}
Console.WriteLine(b);