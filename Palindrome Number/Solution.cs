public class Solution {
    public bool IsPalindrome(int x) {
        int reversed = 0;
        int reference = x;
        if (reference < 0) {
            return false;
        }
        int digit = 0;
        while (x != 0) {
            digit = x % 10;
            reversed = (reversed * 10) + digit;
            x = x / 10;
        }
        if (reversed == reference) {
            return true;
        }
        return false;
    }
}
