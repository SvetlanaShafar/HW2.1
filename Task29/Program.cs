Console.Clear();
Console.WriteLine("Введите цифру 8, для соответсвия условию задачи:");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

int i = 0;
while (a < 8 || a > 8)
{
    Console.WriteLine("Введите цифру 8, для соответсвия условию задачи:");
    a = Convert.ToInt32(Console.ReadLine());
}

while (i < array.Length)
{
    Console.WriteLine("Введите " + i + " элемент массива :");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

Console.Write(" Массив из 8 эллементов ");
Console.WriteLine($"[{string.Join(",", array)}]");
