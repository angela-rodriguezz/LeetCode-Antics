public class Solution {
    public void Rotate(int[] nums, int k) {
        // rotate array to right by k steps
        k = k % nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    public void Reverse(int[] arr, int first, int last) {
        int temp = 0;
        while (true) {
            if (first >= last) {
                break;
            }
            temp = arr[first];
            arr[first] = arr[last];
            arr[last] = temp;
            first += 1;
            last -= 1;
        }
    }
}
