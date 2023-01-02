//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/* 
int[] GetMassiv(int n)
{
    int[] massiv = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(100, 1000);
    }

    return massiv;
}

int EvenNumbersCount(int[]Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
       if(Array[i]%2 == 0)
        {
            count++;
        } 
    }

    return count;
}

int[] array = GetMassiv(9);

int count = EvenNumbersCount(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine(count);
*/

/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
/*
int[] GetMassiv(int n, int min, int max)
{
    int[] massiv = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(min, max);
    }

    return massiv;
}

int SumOfOddItems(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];   
        }

    }

    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = GetMassiv(10, 0, 100);
int sum = SumOfOddItems(array);

PrintArray(array);

Console.WriteLine();

Console.WriteLine(sum);
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

//[3 7 22 2 78] -> 76

int[] GetMassiv(int n, int min, int max)
{
    int[] massiv = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(min, max);
    }

    return massiv;
}

int DiffBetweenMaxAndMin(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }

        if(array[i] > max)
        {
            max = array[i];
        }
    }

    return max - min;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = GetMassiv(10, 0, 100);
int diff = DiffBetweenMaxAndMin(array);

PrintArray(array);

Console.WriteLine();

Console.WriteLine(diff);