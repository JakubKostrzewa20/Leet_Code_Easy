public class Solution
{
    public int RomanToInt(string s)
    {
        var Roman = new Dictionary<char, int>();
        Roman.Add('I', 1);
        Roman.Add('V', 5);
        Roman.Add('X', 10);
        Roman.Add('L', 50);
        Roman.Add('C', 100);
        Roman.Add('D', 500);
        Roman.Add('M', 1000);
        int last = 0;
        int sum = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int current = Roman[s[i]];
            if (current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }
            last = current;
        }
        return sum;
    }
}