public class Solution {
    public string IntToRoman(int num) {
        var builder = new StringBuilder();
        int digit = 0;
        IDictionary<int, string> reference = new Dictionary<int, string>{
            {1, "I"},
            {5, "V"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"},
            {4, "IV"},
            {9, "IX"},
            {40, "XL"},
            {90, "XC"},
            {400, "CD"},
            {900, "CM"}
        };
        if (num >= 1000) {
            Getter(num, 1000, builder);
            num = num % 1000;
        } if (num >= 100) {
            Getter(num, 100, builder);
            num = num % 100;
        } if (num >= 10) {
            Getter(num, 10, builder);
            num = num % 10;
        } if (num > 0) {
            Getter(num, 1, builder);
        }
        return builder.ToString();

        void Getter(int curr, int value, StringBuilder item) {
            digit = curr / value;
                if (digit > 5 && digit != 9) {
                item.Append(reference[5 * value]);
                digit -= 5;
                }
            if (digit != 4 && digit != 9 && digit != 5) {
                for (int i = 0; i < digit; i++) {
                    item.Append(reference[value]);
                }
            } else {
                item.Append(reference[digit * value]);
            }
        }
    }
}
