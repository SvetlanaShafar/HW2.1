Console.Clear();
Console.WriteLine("Введите количество кустов из предела [3...1000]");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 3 || a > 1000)
{
    Console.WriteLine("Введите число из предела [3...1000]");
    a = Convert.ToInt32(Console.ReadLine());
}

void Fillarray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {

        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pisition = 0;
    while (pisition < count)
    {
        Console.Write(" " + col[pisition]);
        pisition++;
    }
}


int[] array = new int[a];
Fillarray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(array[2]);
int i = 1;
int max1 = 0;
int max = 0;
while (i < a)
{
    max1 = array[i] + array[i - 1] + array[i + 1];
    if (max1 > max)
        max = max1;
    i += 2;

}

Console.WriteLine(max);