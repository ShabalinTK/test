using System.Text;

namespace MatrixClass
{
    internal class Matrix
    {
        private int rows;
        private int columns;
        private int[,] matr;

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
            get { return matr[i, j]; }
            private set { matr[i, j] = value; }
        }

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            matr = new int[rows, columns];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    sb.Append($"{matr[i, j],2}");
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
            this.matr = new int[rows, columns];

            var matrix = streamReader.ReadToEnd().Split('\n');

            for (int i = 0; i < rows; i++)
            {
                var r = matrix[i].Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    this.matr[i, j] = Convert.ToInt32(r[j]);
                }
            }
        }

        public void SwapRows()
        {
            int maxSum = int.MinValue;
            int minSum = int.MaxValue;
            int maxSumRow = 0;
            int minSumRow = 0;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < columns; j++)
                {
                    rowSum += matr[i, j];
                }
                if (rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxSumRow = i;
                }
                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minSumRow = i;
                }
            }

            for (int j = 0; j < columns; j++)
            {
                int temp = matr[maxSumRow, j];
                matr[maxSumRow, j] = matr[minSumRow, j];
                matr[minSumRow, j] = temp;
            }
        }
        public class Program
        {
            static void Main()
            {
                var mr = new Matrix("C:/Users/shaba/OneDrive/Рабочий стол/test.txt");
                Console.WriteLine(mr);
                Console.WriteLine("************");
                Console.WriteLine();
                mr.SwapRows();
                Console.WriteLine(mr);
            }
        }
    }
}
