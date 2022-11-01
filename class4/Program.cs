// // Разбор дз. 19 задача
// Console.Clear();
// Console.Write("Введите 5-значное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// n = Math.Abs(n);
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Введите 5-значное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
//     n = Math.Abs(n);
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// // Разбор дополнительной задачи на сбор черники
// Console.Clear();
// Console.Write("Введите кол-во кустов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int[] result = new int[n];

// for (int i = 0; i < array.Length; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < array.Length - 1; i++)
//     result[i - 1] = array[i - 1] + array[i] + array[i + 1];

// result[result.Length - 2] = array[0] + array[array.Length - 1] + array[array.Length - 2];
// result[result.Length - 1] = array[0] + array[1] + array[array.Length - 1];

// Console.WriteLine($"[{string.Join(", ", result)}]");
// int maxValue = result[0];
// for (int i = 1; i < result.Length; i++)
// {
//     if (maxValue < result[i])
//         maxValue = result[i];
// }
// Console.WriteLine(maxValue);



// // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((1 + n) / 2 * n);



// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// do 
// {
//     n= n/10;
// i = i + 1; // i++
// }
// while (n > 0);
// Console.WriteLine(i);

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2);
// Console.WriteLine($"[{string.Join(", ", array)}]");

