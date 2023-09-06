public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // merge in increasing order
        // use m integers in final array should be stored in nums1
        // nums1 has a length already of m + n

        for (int i=m; i < nums1.Length; i++) {
            nums1[i] = nums2[i - m];
        }
        Array.Sort(nums1);
    }
}
