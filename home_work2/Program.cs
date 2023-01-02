//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int GetSecondDigit(int num)
{
    return (num % 100)/10;
}

Console.Write("Input a three digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int dec = GetSecondDigit(num);
Console.WriteLine(dec);*/


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool IsWeekend(int day)
{
    return day == 6 || day == 7;
}

Console.Write("Input a number between 1 and 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if(IsWeekend(day))
{
    Console.Write("weekend ");
}

else
{
    Console.Write("weekday ");
}
