using System.Text;

namespace Matrix
{
    internal class Matrix
    {
        private int rows;
        private int columns;
        private int[,] matrix;

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return columns; }
        }

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            private set { matrix[i, j] = value; }
        }

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            matrix = new int[rows, columns];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    sb.Append($"{matrix[i, j],2}");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public Matrix(string filename)
        {
            using StreamReader streamReader = new StreamReader(filename);
            var sizes = streamReader.ReadLine().Split(' ');

            rows = Convert.ToInt32(sizes[0]);
            columns = Convert.ToInt32(sizes[1]);
            this.matrix = new int[rows, columns];

            var matrix = streamReader.ReadToEnd().Split('\n');

            for (int i = 0; i < rows; i++)
            {
                var r = matrix[i].Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    this.matrix[i, j] = Convert.ToInt32(r[j]);
                }
            }
        }

        public void SwapRows(int a, int b)
        {
            for (int i = 0; i < columns; i++)
            {
                (matrix[a, i], matrix[b, i]) = (matrix[b, i], matrix[a, i]);
            }
        }

        public void SwapRowsMaxMin()
        {
            var max = int.MinValue;
            var maxindex = 0;
            var min = int.MaxValue;
            var minindex = 0;

            for (int i = 0; i < rows; i++)
            {
                int summa = 0;
                for (int j = 0; j < columns; j++)
                    summa += matrix[i, j];
                if (summa > max)
                {
                    max = summa;
                    maxindex = i;
                }
                if (summa < min)
                {
                    min = summa;
                    minindex = i;
                }
            }

            SwapRows(maxindex, minindex);
        }
    }

    public class Program
    {
        static void Main()
        {
            var m1 = new Matrix("C:/Users/Admin/Desktop/test.txt");
            Console.WriteLine(m1);

            Console.WriteLine("************");

            m1.SwapRowsMaxMin();
            Console.WriteLine(m1);
        }
    }
}