Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


while (k2==k1)
{
Console.Write("Введите k1: ");
 k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
 k2 = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());


double x=(b1-b2)/(k2-k1);
double y= k1 * x + b1;
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x} Y: {y}");