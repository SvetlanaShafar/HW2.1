
int RecursiveSum(int a, int b)
{
    if (a == b)
        return a;

    return a + RecursiveSum(a + 1, b);
}


Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(RecursiveSum(a, b));




 
