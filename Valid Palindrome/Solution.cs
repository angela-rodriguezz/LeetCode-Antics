public class Solution {
    public bool IsPalindrome(string s) {
        // must reverse the string after removing characters
        s = s.ToLower();
        char[] query = s.Where(x => Char.IsLetterOrDigit(x)).ToArray();
        char[] reversed = s.Where(x => Char.IsLetterOrDigit(x)).Reverse().ToArray();
        for (int i = 0; i < query.Length; i++) {
            if (query[i] != reversed[i]) {
                return false;
            }
        }
        return true;

    }
}
