public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // return true if ANY VALUE appears at least twice
        // false if every element distinct
        HashSet<int> value = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (value.Contains(nums[i])) {
                return true;
            }
            value.Add(nums[i]);
        }
        return false; 
    }
}
