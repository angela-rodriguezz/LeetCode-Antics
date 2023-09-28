public class Solution {
    public int StrStr(string haystack, string needle) {
        int index = 0;
        char match = needle[0];
        int accuracy = 0;
        while (index < haystack.Length) {
            if (haystack[index] == match) {
                for (int i = index; i < haystack.Length; i++) {
                    if (haystack[i] != match) {
                        break;
                    } if (haystack[i] == match) {
                        accuracy += 1;
                        if (accuracy >= needle.Length) {
                            return index;
                        }
                        match = needle[accuracy];
                    }
                }
                accuracy = 0;
                match = needle[accuracy];
            }
            index += 1;
        }
        return -1;
    }
}
