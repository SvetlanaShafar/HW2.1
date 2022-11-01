// // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.Clear();
// Console.Write("Введите координату х: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату у: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0)
// {
//     Console.Write("Введите координату х: ");
//     x = Convert.ToDouble(Console.ReadLine());
// }
// while (y == 0)
// {
//     Console.Write("Введите координату y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");


// // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (Х и У)
// Console.Clear();
// Console.Write("Введите четверть: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n > 4)
// {
//      Console.WriteLine("Вы ошиблись! Введите номер четверти: ");
//         n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//     Console.WriteLine("x > 0 and y > 0");
// else if (n == 2)
//     Console.WriteLine("x < 0 and y > 0");
// else if (n == 3)
//     Console.WriteLine("x < 0 and y < 0");
// else
//     Console.WriteLine("x > 0 and y < 0");

//  //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.       
// Console.Clear();
// Console.Write("Введите первую координату х: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите первую координату у: ");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую координату х: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите вторую координату у: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// double s =(Math.Round(Math.Sqrt(Math.Pow(x1 - x , 2) + Math.Pow(y1 - y , 2)), 3));
// Console.WriteLine($"Расстояние между точками: {s}");


// // //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
//     Console.Write($"{i * i} ");


