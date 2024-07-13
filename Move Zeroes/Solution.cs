class Solution {
    public void moveZeroes(int[] nums) {
        int left = 0;
        int right = 1;
        
        while (right < nums.length && nums.length > 1) {
            if (nums[left] == 0) {
                while (right < nums.length && nums[right] == 0) {
                    right += 1;
                }
                if (right < nums.length) {
                    nums[left] = nums[right];
                    nums[right] = 0;
                }
            }
            right += 1;
            left += 1;
        }
    }
}
