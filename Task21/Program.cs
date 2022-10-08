Console.Clear();
Console.Write("Введите x =");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y =");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z =");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x1 =");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1 =");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z =");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write($"  Расстояние в 3D пространстве: {Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1) + (z - z1) * (z - z1))} ");
