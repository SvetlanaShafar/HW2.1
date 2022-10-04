Console.Clear();
Console.WriteLine("Введите любую цифру:");
int a = Convert.ToInt32(Console.ReadLine());
if (a==6 || a==7)

  Console.WriteLine("Сегодня выходной");  

if (a < 1 || a > 7)

    Console.WriteLine("Такого дня не существует");

if (a > 1 && a < 5 )

   Console.WriteLine("Сегодня будний день");
