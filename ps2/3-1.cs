﻿Console.WriteLine(Left(0, 2, 10000));
Console.WriteLine(Right(0, 2, 10000));
Console.WriteLine(Trapezium(0, 2, 10000));
Console.WriteLine(MethodSimpson(0, 2, 1000000));
Console.WriteLine(MethodMonteCarlo(0, 2, 50000));


static double F(double x)
{
    return Math.Sin(x * x);
}


static double Left(double left, double right, double segmentCount)
{
    double segmentLength = 1 / segmentCount;
    double res = 0;
    for (double i = left; i < right; i += segmentLength)
    {
        res += F(i) * segmentLength;
    }
    return res;
}

static double Right(double left, double right, double segmentCount)
{
    double segmentLength = 1 / segmentCount;
    double res = 0;
    for (double i = left; i <= right - segmentLength; i += segmentLength)
    {
        res += F(i + segmentLength) * segmentLength;
    }
    return res;
}

static double Trapezium(double left, double right, double segmentCount)
{
    double segmentLength = 1 / segmentCount;
    double res = 0;
    for (double i = left; i <= right - segmentLength; i += segmentLength)
    {
        res += (F(i) + F(i + segmentLength)) / 2 * segmentLength;
    }
    return res;
}

static double MethodSimpson(double left, double right, double segmentCount)
{
    double res = 0;
    double segmentLength = 0;
    if (segmentCount % 2 == 1) segmentCount++;
    segmentLength = 1 / segmentCount;
    for (double i = left; i < right; i += segmentLength)
    {
        res += segmentLength / 6 * (F(i) + 4 * F((2 * i + segmentLength) / 2) + F(i + segmentLength));
    }
    return res;
}
