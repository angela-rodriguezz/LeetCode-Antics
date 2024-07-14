class Solution {
    public boolean isSubsequence(String s, String t) {
        int sInd = 0;
        int tInd = 0;

        while (tInd < t.length() && sInd < s.length()) {
            if (s.charAt(sInd) == t.charAt(tInd)) {
                sInd += 1;
            } 
            tInd += 1;
        }

        if (sInd < s.length()) {
            return false;
        }
        return true;
    }
}
