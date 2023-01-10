/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int[,] GetRandMatrix(int rows, int cols, int min, int max)
{
    int[,] result = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i,j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetRandMatrix(4, 5, -10, 10);

PrintMatrix(matrix);

/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

(int, bool) GetItem(int[,] matrix, int row, int col)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;

    if (row < 0 || row >= rows || col < 0 || col >= cols) {
        return (0, false);
    }

    return (matrix[row, col], true);
}

int ReadInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите строку: ");
int r = ReadInt();

Console.Write("Введите столбец: ");
int c = ReadInt();

int item = 0;
bool has = false;
(item, has) = GetItem(matrix, r, c);

if (!has) {
    Console.WriteLine("Такого элемента нет");
} else {
    Console.WriteLine(item);
}

/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

float[] GetColsAvg(int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.Length / rows;

    float[] result = new float[cols];
    for (int i = 0; i < cols; i++)
    {
        result[i] = 0;
        for (int j = 0; j < rows; j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] /= rows;
    }

    return result;
}

void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Среднее арифметическое столбцов:");
PrintArray(GetColsAvg(matrix));