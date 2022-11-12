// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 10);
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// void ReleaseMatrix(int[,] matrix)
// {
//     int max = matrix[0, 0];
//     int indexi = 0;
//     int indexj = 0;
//     int count=0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] > max)
//             {
//                 max = matrix[i, j];
//                 indexi = i;
//                 indexj = j;
//             }
//         }

//     }
//      for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == max)
//            count++;
//         }

//     }
//  Console.WriteLine(count);
// }


// Console.Clear();
// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);

  void InputMatrix(int[,] matrix)
{
    int s = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            s++;
            if (i % 2 == 0)
                matrix[i, j] = s;
            else
                matrix[i, matrix.GetLength(1) - j - 1] = s;
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    int maxNumber = matrix[0, 0], maxRow = 0, maxColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);