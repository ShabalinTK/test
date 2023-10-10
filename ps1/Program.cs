using System;
using System.Linq;
// 2-10 задача 
//class HW
//{
//    static void Main()
//    {
//        int bn = 0;
//        int n =  int.Parse(Console.ReadLine());
//        while (n >= 1)
//        {
//            bn = n % 2;
//            n = n / 2;
//            Console.Write(bn);
//        }
//    }
//}



//1-19 задача
//class Prod
//{
//    static void Main()
//    {
//        int count = 0;
//        string number1 = Console.ReadLine();
//        string number2 = Console.ReadLine();
//        if (number1.Length == 4 && number2.Length == 4)
//        {
//            if ((number1[0] == number2[1]) || (number1[0] == number2[2]) || (number1[0] == number2[3]))
//            {
//                count++;
//            }
//            if ((number1[1] == number2[2]) || (number1[1] == number2[3]) || (number1[1] == number2[0]))
//            {
//                count++;
//            }
//            if ((number1[2] == number2[3]) || (number1[2] == number2[0]) || (number1[2] == number2[1]))
//            {
//                count++;
//            }
//            if ((number1[3] == number2[0]) || (number1[3] == number2[1]) || (number1[3] == number2[2]))
//            {
//                count++;
//            }
//            Console.WriteLine(count);
//        }
//        else
//            Console.WriteLine("не правильная длина или символы");
//    }
//}

//1-19 задача
//class Prog
//{
//    static void Main()
//    {
//        var count = 0;
//        string number1 = Console.ReadLine();
//        string number2 = Console.ReadLine();
//        for (int i = 0; i < number1.Length; i++)
//        {
//            for (int j  = 0; j < number2.Length; j++)
//            {
//                if (j > i || i > j)
//                {
//                    if (number1[i] == number2[j])
//                    {
//                        count++;
//                    }
//                }
//            }
//        }
//        Console.WriteLine(count);
//    }
//}


// 4-12 задача
//class Prog
//{
//    static void Main()
//    {
//        int n = 0;
//        int k = int.Parse(Console.ReadLine());
//        int m = int.Parse(Console.ReadLine());
//        for (int x = 0; x <= m - 1; x++)
//        {
//            for (int y = 0; y <= m - 1; y++)
//            {
//                for (int z = 0; z <= m - 1; z++)
//                {
//                    Console.WriteLine($" способ {x},{y},{z}");
//                    if ((Math.Pow(x, k) % m) == ((Math.Pow(y, k) % m) + (Math.Pow(z, k) % m)))
//                    {
//                        n++;
//                        Console.WriteLine($" сработал {x + "," + y + "," + z}");
//                    }
//                }
//            }
//        }
//        Console.WriteLine(n);
//    }
//}
