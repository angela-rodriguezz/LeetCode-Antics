public class Solution {
    public int FirstUniqChar(string s) {
        IDictionary<char, int> reference = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (reference.ContainsKey(s[i])) {
                reference[s[i]] += 1;
            } else {
                reference.Add(s[i], 1);
            }
        }
        for (int i = 0; i < s.Length; i++) {
            if (reference[s[i]] == 1) {
                return i;
            }
        }
        return -1;
    }
}
