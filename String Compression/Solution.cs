class Solution {
    public int compress(char[] chars) {
        int size = 0;
        int consecutive = 0;
        int firstIndex = 0;
        boolean search = false;
        // iterate through the input array checking the first and next character are equal or not...
        /** 
        for (int i = 0, j = 1; i < chars.length - 1 && j < chars.length; i++, j++) {
            if (chars[i] == chars[j]) {
                if (!search) {
                    search = true;
                    consecutive += 1;
                }
                consecutive += 1;
            } if ((chars[i] != chars[j] && search) ||) {
                if (consecutive >= 10) {
                    chars[firstIndex] = chars[i]; 
                    size += 1;
                    for (char num : Integer.toString(consecutive).toCharArray()) {
                        chars[firstIndex++] = num; 
                        size += 1;
                    }
                } else {
                    size += 2;
                    System.out.println(chars[i]);
                    chars[firstIndex] = chars[i];
                    firstIndex += 1;
                    
                    chars[firstIndex] = (char) (consecutive + '0');
                }
                search = false;
                firstIndex += 1;
                consecutive = 0;
            } else if (chars[i] != chars[j]) {
                chars[firstIndex] = chars[i];
                size += 1;
            }
        }
        return size;
        */

        for (int i = 0; i < chars.length;) {
            char curr = chars[i];
            consecutive = 0;
            while (i < chars.length && chars[i] == curr) {
                consecutive += 1;
                i += 1;
            }
            chars[firstIndex++] = curr;
            if (consecutive > 1) {
                for (char item : String.valueOf(consecutive).toCharArray()) {
                    chars[firstIndex++] = item;
                }
            }
        }

        return firstIndex;
    }
}
