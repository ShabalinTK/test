using System;

//2 - 10 задача
class HW
{
    static void Main()
    {
        int bn = 0;
        int n = int.Parse(Console.ReadLine());
        while (n >= 1)
        {
            bn = n % 2;
            n = n / 2;
            Console.Write(bn);
        }
    }
}