using System;

//4 - 12 задача
class Prog
{
    static void Main()
    {
        int n = 0;
        int k = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        for (int x = 0; x <= m - 1; x++)
        {
            for (int y = 0; y <= m - 1; y++)
            {
                for (int z = 0; z <= m - 1; z++)
                {
                    Console.WriteLine($" способ {x},{y},{z}");
                    if ((Math.Pow(x, k) % m) == ((Math.Pow(y, k) % m) + (Math.Pow(z, k) % m)))
                    {
                        n++;
                        Console.WriteLine($" сработал {x + "," + y + "," + z}");
                    }
                }
            }
        }
        Console.WriteLine(n);
    }
}