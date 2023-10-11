using System;

//1 - 19 задача
class Prog
{
    static void Main()
    {
        var count = 0;
        string number1 = Console.ReadLine();
        string number2 = Console.ReadLine();
        for (int i = 0; i < number1.Length; i++)
        {
            for (int j = 0; j < number2.Length; j++)
            {
                if (j > i || i > j)
                {
                    if (number1[i] == number2[j])
                    {
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
