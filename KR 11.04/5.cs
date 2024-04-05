namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] mas1 = { 1, 2, 3 };
            int[] mas2 = { 4, 5, 6 };
            int[] result = new int[mas1.Length + mas2.Length];

            program.Copy(mas1, 0, result, 0, mas1.Length);
            program.Copy(mas2, 0, result, mas1.Length, mas2.Length);

            foreach (int e in result)
            {
                Console.WriteLine(e);
            }

        }

        public T[] MergeArrays<T>(T[] mas1, T[] mas2)
        {
            T[] result = new T[mas1.Length + mas2.Length];
            Copy(mas1, 0, result, 0, mas1.Length);
            Copy(mas2, 0, result, mas1.Length, mas2.Length);
            return result;
        }

        public T[] Copy<T>(T[] sourceArray, int sourceIndex, T[] destinationArray, int destinationIndex, int length)
        {
            for (int i = 0; i < length; i++)
            {
                destinationArray[destinationIndex + i] = sourceArray[sourceIndex + i];
            }

            return destinationArray;
        }

    }
}
