public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // return indexes of numbers that add to target
        IDictionary<int, int> reference = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int getter = nums[i];
            if (reference.ContainsKey(nums[i])) {
                return new int[] {reference[getter], i};
                
            } 
            if (!reference.ContainsKey(target - getter)) {
                reference.Add(target - getter, i);
            }
        }
        return new int[2];
    }
}
