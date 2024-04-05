namespace ConsoleApp4
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

            char capital = Console.ReadKey().KeyChar;
            Console.WriteLine();

            foreach (var e in str)
            {
                if (e.Value[0] == capital)
                {
                    Console.WriteLine(e.Key);
                }
            }
        }
    }
}
