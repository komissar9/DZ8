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
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин целое число в массиве: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс целое число в массиве: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
PrintMatrix(array2D);
int SumRow(int[,] array, int i)

{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumRow(array2D, 0);
for (int i = 1; i < array2D.GetLength(0); i++)
{
    if (sum > SumRow(array2D, i))
    {
        sum = SumRow(array2D, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
