public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] originalString = s.ToCharArray();
        char[] compareString = t.ToCharArray();
        Array.Sort(originalString);
        Array.Sort(compareString);
        return new string(originalString) == new string(compareString);
    }
}
