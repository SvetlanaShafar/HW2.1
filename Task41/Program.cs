// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Введите  к-во чисел");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
string number = string.Empty;
string posit = string.Empty;
int count = 0;
int i = 0;
while (i != a)
{
    Console.Write("Введите  число: ");
    b = Convert.ToInt32(Console.ReadLine());
    if (b > 0)
    {
        posit = posit + Convert.ToString(b) + "  ";
        count++;
    }
    number = number + Convert.ToString(b) + "  ";
    i++;
}
Console.Write("Введенные числа :");
Console.WriteLine(number);
Console.Write("К-во положительных чисел :");
Console.WriteLine(count);
Console.Write("Положительные числа:");
Console.WriteLine(posit);
