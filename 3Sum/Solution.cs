class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
        Arrays.sort(nums); // [-4, -1, -1, 0, 1, 2]
        List<List<Integer>> returner = new ArrayList<>();
        int sum = 0;
        // we want to cycle through nums and makke sure there is no duplicate values so we don't have a repeat of lists within our returned list
        for (int i = 0; i < nums.length - 2; i++) { // want space to check the last two items in the int array
            if (i == 0 || i > 0 && nums[i] != nums[i - 1]) {
                int high = nums.length - 1;
                int low = i + 1;
                sum -= nums[i];
                while (low < high) {
                    if (nums[low] + nums[high] == sum) {
                        returner.add(Arrays.asList(nums[low], nums[high], nums[i]));
                        while (high > low && nums[high] == nums[high - 1]) {high--;} // avoiding having duplicate values within our high pointer
                        while (low < high && nums[low] == nums[low + 1]) {low++;} // avoiding having duplicate values within our low pointer
                        high--; // continuing to increment
                        low++; 
                    } else if (nums[low] + nums[high] < sum) {
                        low++;
                    } else if (nums[low] + nums[high] > sum) {
                        high--;
                    }
                }
                sum = 0;
            }
        }
        return returner;
    }
}
