public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        IDictionary<char, int> reference = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int indexer = 0;
        while (s.Length > 0) {
            if (s.Contains("IV")) {
                s = s.Remove(s.IndexOf("IV", 0), 2);
                total += 4;
            }
            if (s.Contains("IX")) {
                s = s.Remove(s.IndexOf("IX", 0), 2);
                total += 9;
            } if (s.Contains("XL")) {
                s = s.Remove(s.IndexOf("XL", 0), 2);
                total += 40;
            } if (s.Contains("XC")) {
                s = s.Remove(s.IndexOf("XC", 0), 2);
                total += 90;
            } if (s.Contains("CD")) {
                s = s.Remove(s.IndexOf("CD", 0), 2);
                total += 400;
            } if (s.Contains("CM")) {
                s = s.Remove(s.IndexOf("CM", 0), 2);
                total += 900;
            } else {
                if (indexer >= s.Length) {
                    return total;
                }
                total += reference[s[indexer]];
                indexer += 1;
            }
        }
        return total;
    }
}
