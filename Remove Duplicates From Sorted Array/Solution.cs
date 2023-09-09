public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        HashSet<int> reference = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!reference.Contains(nums[i])) {
                nums[k] = nums[i];
                reference.Add(nums[i]);
                k += 1; 
            }
        }
        return k;
    }
}
