/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
class ReverseComparator : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y - x;
    }
}

static class RandomExtensions
{
    public static void Shuffle<T>(this Random rng, T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}

class App
{
    (int, int) GetMatrixSize(int[,] matrix)
    {
        int rows = matrix.GetUpperBound(0) + 1;
        int cols = matrix.Length / rows;

        return (rows, cols);
    }

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

    int[,,] GetRand3dArray(int size1, int size2, int size3)
    {
        int total = size1 * size2 * size3;
        if (total > 90)
        {
            throw new Exception("Слишком много элементов. Максимум 90");
        }
        int[] array = new int[total];
        for (int i = 0; i < total; i++)
        {
            array[i] = i + 10;
        }

        Random rnd = new Random();
        rnd.Shuffle(array);

        int[,,] result = new int[size1, size2, size3];
        int ai = 0;
        for (int i1 = 0; i1 < size1; i1++)
        {
            for (int i2 = 0; i2 < size2; i2++)
            {
                for (int i3 = 0; i3 < size3; i3++)
                {
                    result[i1, i2, i3] = array[ai++];
                }
            }
        }

        return result;
    }

    void Print3dArray(int[,,] array)
    {
        int size1 = array.GetUpperBound(0) + 1;
        int size2 = array.GetUpperBound(1) + 1;
        int size3 = array.Length / size1 / size2;


        Console.WriteLine($"Массив размером {size1} x {size2} x {size3}");
        for (int i1 = 0; i1 < size1; i1++)
        {
            for (int i2 = 0; i2 < size2; i2++)
            {
                for (int i3 = 0; i3 < size3; i3++)
                {
                    Console.Write($"{array[i1, i2, i3]} ({i1}, {i2}, {i3})   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
        }
    }

    int[] GetRow(int[,] matrix, int row)
    {
        (int rows, int cols) = GetMatrixSize(matrix);

        int[] result = new int[cols];

        for (int i = 0; i < cols; i++)
        {
            result[i] = matrix[row, i];
        }

        return result;
    }

    int[,] SortMatrixRows(int[,] matrix)
    {
        (int rows, int cols) = GetMatrixSize(matrix);

        ReverseComparator rc = new ReverseComparator();

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            int[] row = GetRow(matrix, i);
            Array.Sort(row, rc);

            for (int j = 0; j < cols; j++)
            {
                result[i, j] = row[j];
            }
        }

        return result;
    }

    int[] GetRowsSums(int[,] matrix)
    {
        (int rows, int cols) = GetMatrixSize(matrix);

        int[] result = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
            }

            result[i] = sum;
        }

        return result;
    }

    int MinItemIndex(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        int min = array[0];
        int imin = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }

        return imin;
    }

    void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetUpperBound(0) + 1;
        int cols = matrix.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]}, ");
            }
            Console.WriteLine();
        }
    }

    static void Task1()
    {
        App app = new App();
        int[,] matrix = app.GetRandMatrix(5, 7, -10, 10);
        app.PrintMatrix(matrix);
        Console.WriteLine();
        app.PrintMatrix(app.SortMatrixRows(matrix));
    }

    static void Task2()
    {
        App app = new App();
        int[,] matrix = app.GetRandMatrix(5, 7, -10, 10);
        app.PrintMatrix(matrix);
        int[] sums = app.GetRowsSums(matrix);
        Console.WriteLine($"Минимальная сумма в {app.MinItemIndex(sums) + 1} строке");
    }

    static void Task3()
    {
        App app = new App();
        int[,,] arr = app.GetRand3dArray(3,4,5);
        app.Print3dArray(arr);
    }

    static void Main()
    {
        //Task1();
        //Console.WriteLine();
        //Task2();
        Task3();
    }
}

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
static Random rnd = new Random();
static int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}
static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}
static void Main(string[] args)
{
    int[,] array2D = CreateMatrix(rnd.Next(2,4), rnd.Next(2, 4), 0, 9);
    int[,] matrix = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
    PrintMatrix(array2D);
    Console.WriteLine();
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(DivMatrix(array2D, matrix));
    Console.ReadLine();
}
*/