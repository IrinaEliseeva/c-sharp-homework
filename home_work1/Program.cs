
//Задача №1
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
    Console.Write("Input a first number: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a second number: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    if (n1 > n2)
    Console.Write($"{n1} is more than {n2}");
    else 
    Console.Write("{n2} is more than {n1}"); 

//Задача №2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a)
    {
        max = b;
    }
if (c > max)
    {
        max = c;
    }
Console.Write($"maximum number {max}");*/

//Задача №3
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}*/

//Задача №4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < number; i++ )
{
    
    if (i % 2 == 0)
    Console.Write($"{i} ");
}*/
