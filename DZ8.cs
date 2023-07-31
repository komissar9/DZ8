// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите мин целое число в массиве: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите макс целое число в массиве: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }
// Console.Write("Изначальный массив:");
// PrintMatrix(array2D);

// void sort (int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2D.GetLength(1) - 1; k++)
//             {
//                 if (array2D[i, k] < array2D[i, k + 1])
//                 {
//                     int temp = array2D[i, k + 1];
//                     array2D[i, k + 1] = array2D[i, k];
//                     array2D[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// sort (array2D);
// Console.WriteLine("Отсортированный массив:");
// PrintMatrix(array2D);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите мин целое число в массиве: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите макс целое число в массиве: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }
// PrintMatrix(array2D);
// int SumRow(int[,] array, int i)

// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }

// int minSum = 1;
// int sum = SumRow(array2D, 0);
// for (int i = 1; i < array2D.GetLength(0); i++)
// {
//     if (sum > SumRow(array2D, i))
//     {
//         sum = SumRow(array2D, i);
//         minSum = i + 1;
//     }
// }
// Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
// Console.Write("Введите количество строк первой матрицы: ");
// int rowsOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество cтолбцов первой матрицы: ");
// int columnsOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк второй матрицы: ");
// int rowsTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество cтолбцов второй матрицы: ");
// int columnsTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите мин целое число в массиве: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите макс целое число в массиве: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
// int[,] arrayOne = GetMatrix(rowsOne, columnsOne, minRandom, maxRandom);
// int[,] arrayTwo = GetMatrix(rowsTwo, columnsTwo, minRandom, maxRandom);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }
// Console.WriteLine("Первая матрица:");
// PrintMatrix(arrayOne);
// Console.WriteLine("Вторая матрица:");
// PrintMatrix(arrayTwo);
// // Две матрицы можно перемножить если количество столбцов первой матрицы равно количеству строк второй матрицы.
// int [,] arrayThree = new int [rowsOne, columnsTwo];
// if (columnsOne != rowsTwo)
// {
//     Console.WriteLine("Перемножить матрицы нельзя");
// }
// else
// {
//     for (int i = 0; i < rowsOne; i++)
//     {
//         for (int j = 0; j < columnsTwo; j++)
//         {
//             for (int k = 0; k < columnsOne; k++)
//             {
//                 arrayThree [i,j] += arrayOne [i,k] * arrayTwo [k,j];
//             }
//         }
//     }
//     Console.WriteLine("Результат умножения: ");
//     for (int i = 0; i < rowsOne; i++)
//     {
//         for (int j = 0; j < columnsTwo; j++)
//         {
//             Console.Write (arrayThree [i,j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Random number = new Random();

//   int m = 2, n = 2, k = 2;

//   int[,,] array3D = new int[m, n, k];

//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       for (int l = 0; l < k; l++)
//       {
//         array3D[i, j, l] = number.Next(10, 99);
//         Console.Write($"{array3D[i, j, l]}({i},{j},{l}) ");
//       }
//       Console.WriteLine();
//     }
//   } 

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Write("Введите количество строк: ");
int rowsUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columnsUser = Convert.ToInt32(Console.ReadLine());
int[,] array2D = new int[rowsUser, columnsUser];

int i = 0;
int j = -1;

int row = 0;
int col = 1; 

int t = 1;
while (t <= rowsUser * columnsUser)
{
    if (
          (i + row >= 0 & i + row < rowsUser) &&
          (j + col >= 0 & j + col < columnsUser) &&
          array2D[i + row, j + col] == 0
        )
    {
        i += row;
        j += col;
        array2D[i, j] = t++;
    }
    else if (col == 1)
    {
        row = 1;
        col = 0;
    }
    else if (row == 1)
    {
        col = -1;
        row = 0;
    }
    else if (col == -1)
    {
        col = 0;
        row = -1;
    }
    else if (row == -1)
    {
        row = 0;
        col = 1;
    }
}

for (i = 0; i < rowsUser; i++)
{
    for (j = 0; j < columnsUser; j++)
        Console.Write("{0,4}", array2D[i, j]);
    Console.WriteLine();
}