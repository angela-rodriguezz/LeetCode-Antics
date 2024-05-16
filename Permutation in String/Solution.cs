class Solution {
    public boolean checkInclusion(String s1, String s2) {

        if (s1.length() > s2.length()) {
            return false;
        }
        int[] alph1 = new int[26];
        int[] alph2 = new int[26];
        int sizeOne = s1.length(); int sizeTwo = s2.length();

        for (int i = 0; i < sizeOne; i++) {
            alph1[s1.charAt(i) - 'a'] += 1;
            alph2[s2.charAt(i) - 'a'] += 1;
        }

        for (int i = sizeOne; i < sizeTwo; i++) {
            if (checker(alph1, alph2)) {
                return true;
            }
            alph2[s2.charAt(i - sizeOne) - 'a'] -= 1;
            alph2[s2.charAt(i) - 'a'] += 1;
        }
        return checker(alph1, alph2);
    }


    private boolean checker(int[] arr1, int[] arr2) {
        for (int i = 0; i < arr1.length; i++) {
            if (arr1[i] != arr2[i]) {
                return false;
            }
        }
        return true;
    }
}
