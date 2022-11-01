// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}


int Random (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];

    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите количество числе в массиве ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

FillArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Сумма чисел на нечетных позициях: {Random(array)}");
