// 2-6 задача

double eps = double.Parse(Console.ReadLine());
Console.WriteLine(Pi(eps));
Console.WriteLine(Math.PI);
static double Pi(double eps)
{
    double pi = Math.PI;
    double res = 0;
    double k = 0; //cчётчик для нахождения к факториала
    double n = 0; //cчётчик для нахождения 2к факториала
    double l = 0; //cчётчик для нахождения 3к факториала
    double firstfact = 1;
    double secondfact = 1;
    double theirdfact = 1;
    double poweroftwo = 1;
    while (Math.Abs(pi - (res)) > eps)
    {

        res += (50 * k - 6) * firstfact * secondfact / poweroftwo / theirdfact;
        k++;
        poweroftwo *= 2;
        n += 2;
        l += 3;
        firstfact *= k;
        secondfact = secondfact * n * (n - 1);
        theirdfact *= (l - 2) * (l - 1) * l;
    }
    return res;
}