Console.Clear();
Console.WriteLine("введите число от 0 до 100 ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
array[array.Length - 1] = 0;
int first = array[0];
int second = array[0];
int count = 2;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 101);
    array[array.Length - 3] = 0;
Console.WriteLine($"[{string.Join(",", array)}]");

if (array[1] > first)
    first = array[1];
else
    second = array[1];

while (array[count] != 0)
{
    if (array[count] > first)
    {
        second = first;
        first = array[count];
    }
    else
    if (array[count] > second)
        second = array[count];

    count++;
}

Console.WriteLine(first);
Console.WriteLine(second);

