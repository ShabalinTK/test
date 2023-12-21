//1.В строке заменить все маленькие буквы на большие.
//2. В массива найти первое повторяющееся число и поменять его с последним числом

//1 задача
string str = "Я люблю футбол и хоккей!";
string str1 = "";
string[] words = str.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    words[i] = words[i].ToUpper();
}

foreach (var e in words)
{
    str1 += e;
}
Console.WriteLine(str);
Console.WriteLine(str1);

//2 задача

int[] arr = new int[] { 1, 2, 4, 7, 2, 7, 9, 0 };
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    for(int j = 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            arr[i] = arr[arr.Length - 1];
            count++;
        }
        if (count > 0)
            break;

    }
}

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i]);
