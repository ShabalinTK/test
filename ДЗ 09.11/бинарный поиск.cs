static int IndexSearch(int[] array, int first, int last, int value)
{
    if (last < first) return -1;
    int mid = first + (last - first) / 2;
    if (array[mid] == value) return mid;
    return array[mid] > value
    ? IndexSearch(array, first, mid - 1, value)
    : IndexSearch(array, mid + 1, last, value);
}

int[] array = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14 };

Console.WriteLine(IndexSearch(array, 1, 14, 6));
