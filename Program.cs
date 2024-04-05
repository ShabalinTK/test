﻿namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> str = new Dictionary<string, string>
            {
                { "Россия", "Москва" },
                { "Германия", "Берлин" },
                { "Франция", "Мариж" }
            };

            Console.Write("Введите букву:");
            char capital = Console.ReadKey().KeyChar;
            Console.WriteLine();

            foreach (var e in str)
            {
                if (e.Value.StartsWith(capital.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(e.Key);
                }
            }

        }
    }
}