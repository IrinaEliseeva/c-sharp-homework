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

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/