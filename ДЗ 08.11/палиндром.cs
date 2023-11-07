var str = "Казак";

bool IsStringPalindrome(string str, int a, int b)
{
    foreach(var word in str)
    {
        var words = str.ToLower();
        if (a >= b)
        {
            return true;
        }

        if (words[a] == words[b])
        {
            return IsStringPalindrome(str, a + 1, b - 1);
        }
    }

    return false;
}
Console.WriteLine(IsStringPalindrome(str, 0, 4));