public class Solution
{
    public int Question2(string s)
    {
        int result = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>
        {
            { 'I', 1 }, 
            { 'V', 5 }, 
            { 'X', 10 }, 
            { 'L', 50 }, 
            { 'C', 100 }, 
            { 'D', 500 }, 
            { 'M', 1000 } 
        };

        for (int i = 0; i < s.Length; ++i)
        {
            int val = dic[str[i]];
            if (i == s.Length - 1 || dic[s[i + 1]] <= dic[s[i]])
            {
                result = res+val;
            }
            else
            {
                result = res-val;
            }
        }
        return result;

    }
}