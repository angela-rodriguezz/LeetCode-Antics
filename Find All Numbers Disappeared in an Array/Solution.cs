class Solution {
    public List<Integer> findDisappearedNumbers(int[] nums) {
        List<Integer> returner = new ArrayList<>();
        Set<Integer> values = new HashSet<>();

        for (int i = 0; i < nums.length; i++) {
            values.add(nums[i]);
        }

        for (int j = 1; j <= nums.length; j++) {
            if (!values.contains(j)) {
                returner.add(j);
            }
        }
        return returner;
    }
}
