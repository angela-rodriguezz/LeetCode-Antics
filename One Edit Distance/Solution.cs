class Solution {
    public boolean isOneEditDistance(String s, String t) {
        int sizeS = s.length();
        int sizeT = t.length();
        if (sizeT < sizeS) {
            return isOneEditDistance(t, s);
        }
       if (s.equals(t) || sizeT - sizeS > 1) {
            return false;
       }
        int counter = 0;
        for (int i = 0, j = 0; i < sizeS && j < sizeT; j++, i++) {
            if (s.charAt(i) != t.charAt(j)) {
                counter += 1;
                if (sizeT != sizeS) {
                    i -= 1;
                }
            }
       }
       return counter <= 1;
    }
}
