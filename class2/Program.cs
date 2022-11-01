// // Функции, процедура

// // Функции, процедура

// Console.Clear();
// void f(ref int x) // процедура
// {
//     x = x + 10;
// }


// int n = 5;
// Console.WriteLine(n);
// f(ref n);
// Console.WriteLine(n);
// // Сколько значений мы передаем, столько мы и принимаем
// // Сколько значений мы принимаем, столько мы и передаем




// // // Функции, процедура

// Console.Clear();
// string f(int a, int b) // функция
// {
//     if (a > b)
//         return ">";
        
//     return "<";
// }

// Console.WriteLine(f(7, 5));

// // Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Clear();
// int n = new Random().Next(10, 100); // ???
// int n1 = n / 10;
// int n2 = n % 10;
// Console.WriteLine($"Сгенерированное число: {n}");

// if (n1 > n2)
//     Console.WriteLine(n1);
// else if (n1 < n2)
//     Console.WriteLine(n2);
// else
//     Console.WriteLine("=");

// // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Console.Clear();
// int n = new Random().Next(100, 1000); // ???
// int n1 = n / 100;
// int n2 = n % 10;
// Console.WriteLine($"Сгенерированное число: {n}");
// Console.Write(n1); 
// Console.Write(n2);
// // 2 Вариант решения этой задачи
// Console.Clear();
// int n = new Random().Next(100, 1000);
// Console.WriteLine($"{n}\n{n / 100 * 10 + n % 10}");


// //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// if (n % m == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine($"no, ostatok {n % m}");


// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// //  Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// if (n * n == m || m * m == n)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");







