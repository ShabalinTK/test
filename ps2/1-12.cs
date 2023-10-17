//1-12 задача

double x = double.Parse(Console.ReadLine());
Console.WriteLine(Math.Pow(Math.Cos(x), 2));
Console.WriteLine(Cos2(x));

static double Cos2(double x, double eps = 0.0000001)
{
    double res = 1;
    double k = 1;
    double check = Math.Pow(Math.Cos(x), 2);
    double doublefactorial = 2;
    double n = 2;
    double minusone = -1;
    double pow2 = 2;
    double powx = x * x;
    while (Math.Abs(check - res) > eps)
    {
        res += minusone * pow2 * powx / doublefactorial;
        k++;
        minusone *= -1;
        pow2 *= 4;
        powx *= x * x;
        n += 2;
        doublefactorial = n * (n - 1) * doublefactorial;
    }

    return res;
}

