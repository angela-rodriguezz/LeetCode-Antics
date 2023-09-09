public class Solution {
    public int[] PlusOne(int[] digits) {
        // large integer -> int[] digits
        // digits[i] is ith digit of integer 
        // digits ordered from most significiant to least significant from left to right
        // increment large integer by one
        // return resulting array
        int indexer = digits.Length - 1;
        for (int i = indexer; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i] += 1;
                return digits;  
            }
            digits[i] = 0;
        }
            int[] returner = new int[indexer + 2];
            returner[0] = 1;
            return returner; 
    }
}
