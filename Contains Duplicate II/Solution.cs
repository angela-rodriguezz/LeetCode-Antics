class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        // true if TWO DISTINCT INDICES WHERE -> nums[i] == nums[j] && i - j <= k

        Map<Integer, List<Integer>> ref = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            if (ref.containsKey(nums[i])) {
                for (int index : ref.get(nums[i])) {
                    if (Math.abs(i - index) <= k) {
                        return true;
                    }
                }
                ref.get(nums[i]).add(i);
            } else {
                List<Integer> indexList = new ArrayList<>();
                indexList.add(i);
                ref.put(nums[i], indexList);
            }
        } 
        return false;
    }
}
