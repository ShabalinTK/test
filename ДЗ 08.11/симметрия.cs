int[] arr = { 1, 2, 3, 3, 2, 1 };

bool IsArraySymmetric(int[] arr, int a, int b)
{
    if (a >= b)
    {
        return true;
    }

    if (arr[a] == arr[b])
    {
        return IsArraySymmetric(arr, a + 1, b - 1);
    }

    return false;
}
Console.WriteLine(IsArraySymmetric(arr, 0, 5));
