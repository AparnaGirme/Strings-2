// TC => O(m*n)
// SC => O(1)
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == null || needle.Length == 0 || haystack.Length < needle.Length)
        {
            return -1;
        }
        int firstIndex = -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (i + needle.Length > haystack.Length)
                {
                    return firstIndex;
                }
                var k = i + 1;
                firstIndex = i;
                for (int j = 1; j < needle.Length && k < haystack.Length; j++, k++)
                {
                    Console.WriteLine($"haystack[{k}] --> {haystack[k]}");
                    Console.WriteLine($"needle[{j}] --> {needle[j]}");
                    if (haystack[k] != needle[j])
                    {
                        firstIndex = -1;
                        break;
                    }
                }
                if (firstIndex != -1)
                {
                    return firstIndex;
                }
            }
        }
        return firstIndex;
    }
}