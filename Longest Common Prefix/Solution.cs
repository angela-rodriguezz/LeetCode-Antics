public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder returner = new StringBuilder();
        if (strs.Contains("")) {
            return "";
        } if (strs.Length == 1) {
            return strs[0];
        }
        for (int i = 0; i < strs[0].Length; i++) {
            for (int j = 1; j < strs.Length; j++) {
                if (strs[j].Length <= i || strs[j][i] != strs[0][i]) {
                    return returner.ToString();
                } else if (j == strs.Length - 1 && strs[j][i] == strs[0][i]) {
                    returner.Append(strs[j][i]);
                }
            }
        }
        return returner.ToString();
    }
}
