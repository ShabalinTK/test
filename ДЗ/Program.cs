//ЗАДАЧА 1
//using System;
//
//class Prog
//{
//    static void Main()
//    {
//        int n = 10;
//        int[] array = new int[n];
//        int max = int.MinValue;
//        Random random = new Random();
//        for (int i = 0; i < n; i++)
//        {
//            array[i] = random.Next(-100, 100);
//            if (max < array[i] && array[i] < 0)
//            {
//                max = array[i];
//            }
//            Console.WriteLine(array[i]);
//        }
//        Console.WriteLine();
//        Console.WriteLine(max);
//    }
//}


//ЗАДАНИЕ 2-3

//class Prog
//{
//    static void Main(string[] args)
//    {
//        int number = int.MinValue;
//        int count = 0;
//        int number1 = 0; int number2 = 0;
//        int[] array = {8, 4, 5, 8, 2, 5, 7, 8};
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (number < array[i])
//            {
//                number = array[i];
//                number1 = i;
//            }
//        }
//        for (int i = 0; i < array.Length;  i++)
//        {
//            if (number == array[i])
//            {
//                count++;
//                number2 = i;
//            }
//        }
//        Console.WriteLine(number1);
//        Console.WriteLine(number2);
//        Console.WriteLine(number);
//        Console.WriteLine(count);
//    }
//}


