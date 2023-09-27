public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        long reference = 0;
        bool negative = false;
        if (s.Length > 0 && s[0] == '-') {
            negative = true;
            s = s.Remove(0, 1);
        } else if (s.Length > 0 && s[0] == '+') {
            negative = false;
            s = s.Remove(0, 1);
        }
        for (int i = 0; i < s.Length; i++) {
            if (!Char.IsDigit(s[i])) {
                break;
            }
            if (Char.IsDigit(s[i])) {
                reference = (reference * 10) + (long) Char.GetNumericValue(s[i]);
                if (reference > int.MaxValue && negative) {
                    return int.MinValue;
                } else if (reference >= int.MaxValue && !negative) {
                    return int.MaxValue;
                }
            }
        }
        if (negative) {
            return -1 * (int) reference;
        }
        return (int) reference;
    }
}
