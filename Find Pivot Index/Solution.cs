class Solution {
    public int pivotIndex(int[] nums) {
        /**
        1. iterating through array nums 
        2. gather the sums of the different numbers on the left while gathering sums from the right
        3. create a hashset -> input the sums of the ones on the left abd check if the pointer on the right equals any of them? NOPE
        3. create a hashmap that inputs the sums of the ones of the left and the ones on the right???

        EX) nums = [1,7,3,6,5,6]

        0 -> 1 -> 8 -> 11 -> 17 -> 22 -> 28
         */

        int total = nums.length;
        int adderL = 0;
        int adderR = 0;
        int[] lSum = new int[total];
        int[] rSum = new int[total];

        for (int i = 0; i < total; i++) {
            if (i > 0) {
                adderL += nums[i - 1];
                lSum[i] = adderL;
            }
            for (int j = total - 1; j > i; j--) {
                adderR += nums[j];
                rSum[i] = adderR;
            }
            adderR = 0;
        }

        for (int i = 0; i < total; i++) {
            if (lSum[i] == rSum[i]) {
                return i;
            }
        }
        return -1;
    }
}
