//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// int SummaPositiveNumbers(int[] array)
// {
//    int summaP = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0)
//          summaP = summaP + array[i]; // summaP += array[i];
//    }

//    return summaP;
// }


// int SummaNegativeNumbers(int[] array)
// {
//    int summaN = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] < 0)
//          summaN = summaN + array[i]; // summaP += array[i];
//    }

//    return summaN;
// }


// Console.Clear();
// int[] array = new int[12];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма положительных элементов равна: {SummaPositiveNumbers(array)}");
// Console.WriteLine($"Сумма отрицательных элементов равна: {SummaNegativeNumbers(array)}");


// // Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// void ReleaseArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = array[i] * (-1);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-9, 10);
// }


// string ReleaseArray(int[] array, int number)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] == number)
//          return "yes";
//    }
//    return "no";
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое Вы хотите найти: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{ReleaseArray(array, m)}");


// //  Задайте одномерный массив из 123 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(-100, 100);
// }


// int ReleaseArray(int[] array)
// {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] >= 10 && array[i] <= 99)
//          count++; // count = count + 1
//    }
//    return count;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// Console.Write(ReleaseArray(array));




// // Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// void InputArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//       array[i] = new Random().Next(1, 6);
// }


// void ReleaseArray(int[] array)
// {
//    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//    {
//       Console.Write($"{array[i] * array[array.Length - i - 1]} ");
//    }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);


