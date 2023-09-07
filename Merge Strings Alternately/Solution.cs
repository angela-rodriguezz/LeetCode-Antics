public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int index = 0;
        char[] returner = new char[word1.Length + word2.Length];
        for (int i = 0; i < word1.Length + word2.Length; i++) {
            if (word1.Length > i && word2.Length > i) {
                returner[index] = word1[i];
                returner[index + 1] = word2[i];
                index += 2;
            } else if (word1.Length > i) {
                returner[index] = word1[i];
                index += 1;
            } else if (word2.Length > i) {
                returner[index] = word2[i];
                index += 1;
            } 
        }
        return new string(returner);
    }
}
