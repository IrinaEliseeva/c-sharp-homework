/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/*
void PrintN(int n)
{
    Console.Write(n);
    if (n <= 1)
    {
        return;
    }
    Console.Write(", ");
    PrintN(n - 1);
}

Random rnd = new Random();
PrintN(rnd.Next(10, 30));
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

/* 
int Sum(int m, int n)
{
    if (m >= n)
    {
        return n;
    }

    return m + Sum(m + 1, n);
}

Random rnd = new Random();
int m = rnd.Next(0, 10);
int n = rnd.Next(15, 20);
Console.Write($"{m} {n} {Sum(m, n)}");
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int a, int b)
{
    if (a <= 0)
    {
        return b + 1;
    }

    if (b == 0)
    {
        return Akkerman(a - 1, 1);
    }
    return Akkerman(a - 1, Akkerman(a, b - 1));
}

Random rnd = new Random();
int m = rnd.Next(1, 4);
int n = rnd.Next(1, 4);
Console.Write($"{m} {n} {Akkerman(m, n)}");