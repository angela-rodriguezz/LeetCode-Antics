class Solution {
    public boolean canPermutePalindrome(String s) {
       /**
       1. iterate through the string
       2. check the frequency of each of the letters with one another -> use the alphabet and subtract 
       3. iterate through alph array and check if all are even OR only ONE odd frequency of a letter
        */
        int[] alph = new int[26];
        int numOdd = 0;
        for (int i = 0; i < s.length(); i++) {
            alph[s.charAt(i) - 'a'] += 1;
        }
        for (int j = 0; j < alph.length; j++) {
            if (alph[j] % 2 == 1 && numOdd > 0) {
                return false;
            } if (alph[j] % 2 == 1) {
                numOdd += 1;
            } 
        }
        return true;
    }
}
