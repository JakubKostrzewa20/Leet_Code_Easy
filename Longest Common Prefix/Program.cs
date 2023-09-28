public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        int minLength = strs.Min(x => x.Length);
        string shortest_element = strs.FirstOrDefault(x => x.Length == minLength);
        foreach (string item in strs)
        {
            for (int j = 0; j < minLength; j++)
            {
                if (item[j] != shortest_element[j])
                {
                    minLength = j;
                    break;
                    if (minLength == 0)
                    {
                        return "";
                    }
                }
            }
        }
        return shortest_element.Substring(0, minLength);
    }
}