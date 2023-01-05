/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

/*int[] ReadNumbers()
{
    string sIn = Console.ReadLine();
    string[] strings = sIn.Split(",");

    int[] nums = new int[strings.Length];
    for (int i = 0; i < strings.Length; i++)
    {
        nums[i] = Convert.ToInt32(strings[i]);
    }

    return nums;
}

int CountPositiveNums(int[] nums)
{
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("Введите числа через запятую: ");

int count = CountPositiveNums(ReadNumbers());

Console.WriteLine($"Положительных чисел: {count}");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1x + b1 = k2x + b2 
// x(k1 - k2) = b2 - b1
// x = (b2 - b1)/(k1 - k2)

int ReadInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите k1: ");
int k1 = ReadInt();

Console.Write("Введите b1: ");
int b1 = ReadInt();

Console.Write("Введите k2: ");
int k2 = ReadInt();

Console.Write("Введите b2: ");
int b2 = ReadInt();

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
    return;
}

float x = (b2 - b1) / (k1 - k2);
float y = k1 * x + b1;

Console.WriteLine($"Прямые пересекаются в точке ({x}, {y})");