// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 50);
}


double Random(double[] array)
{
   double diff =0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];

    }
    diff =max -min;
    return diff;
}

Console.Clear();
Console.WriteLine("Введите количество числе в массиве ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];

FillArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным числом массива: {Random(array)}");
