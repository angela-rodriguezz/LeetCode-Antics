class Solution {
    public int[] sortedSquares(int[] nums) {
        
        int[] sort = new int[nums.length];
        int left = 0;
        int right = nums.length - 1;
        for (int i = nums.length - 1; i >= 0; i--) {
            if (Math.abs(nums[left]) > nums[right]) {
                sort[i] = (int) Math.pow(nums[left], 2);
                left += 1;
            } else {
                sort[i] = (int) Math.pow(nums[right], 2);
                right -= 1;
            }
        }

        return sort;
    }
}
