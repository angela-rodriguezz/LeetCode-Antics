public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // remove all occurences of int in nums -> in-place
        // order of elements can be changed
        // remove # elements in nums != val
        // ex) [1,2,3,4], val=3 -> returns 3 b/c [1,2,_,4]
        // MUST CHANGE nums array so first k AREN'T == val
        // return the # k
        int index = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[index] = nums[i];
                index += 1;
            }
            
        }
        return index;
    }
}
