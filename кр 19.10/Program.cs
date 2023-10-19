// 1 задача

int max = int.MinValue;
int min = int.MaxValue;

int[] mas = { 1, 5, 3, 32, 6, };

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > max)
    {
        max = mas[i];
    }
}

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] < min)
    {
        min = mas[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max + min);

// 3 задача

Random rand = new Random();

int n = 4;
int[,] matri = new int[n, n];

int longg = matri.GetLength(0);
int hight = matri.GetLength(1);

for (int x = 0; x < longg; x++)
{
    for (int y = 0; y < hight; y++)
    {
        matri[x, y] = rand.Next(50);
        Console.Write(matri[x, y] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int x = 0; x < hight; x++)
{
    for (int y = x + 1; y < longg; y++)
    {
        int xt = matri[x, y];
        matri[x, y] = matri[y, x];
        matri[y, x] = xt;
    }
}

for (int x = 0; x < hight; x++)
{
    for (int y = 0; y < longg; y++)
    {
        Console.Write(matri[x, y] + "\t");
    }
    Console.WriteLine();
}
