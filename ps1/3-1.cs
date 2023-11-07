using System;

public class Program
{
    public static long GreatestCommonDivisor(long a, long b) // НОД
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static long LeastCommonMultiple(long a, long b) //НОК
    {
        return (a / GreatestCommonDivisor(a, b)) * b;
    }

    public static void Main()
    {
        Console.Write("Введите количество чисел: ");
        int count = int.Parse(Console.ReadLine());

        long[] numbers = new long[count];

        Console.WriteLine("Введите числа:");
        for (int i = 0; i < count; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        long lcm = numbers[0];
        for (int i = 1; i < count; i++)
        {
            lcm = LeastCommonMultiple(lcm, numbers[i]);
        }

        Console.WriteLine($"Наименьшее общее кратное: {lcm}");
    }
}
