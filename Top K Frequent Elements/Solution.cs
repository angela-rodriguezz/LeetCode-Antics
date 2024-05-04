class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        /**
        k most frequent elements
        iterate through nums 
        HashMap
        MAPPING : index of nums == 
        -1, -1, 
         */     
        int counter = 0;
        int curr = 0;
        Map<Integer, Integer> ref = new HashMap<>();
        int[] returner = new int[k];
        for (int i = 0; i < nums.length; i++) {
            ref.put(nums[i], ref.getOrDefault(nums[i], 0) + 1);
        }

        List<Integer>[] allInt = new List[nums.length + 1];
        for (int item : ref.keySet()) {
            curr = ref.get(item);
            if (allInt[curr] == null) {
                allInt[curr] = new ArrayList<>();
            }
            allInt[curr].add(item);
        }
        for (int i = nums.length; i > 0 && counter < k; i--) {
            if (allInt[i] != null) {
                for (int j = 0; j < allInt[i].size() && counter < k; j++) {
                    returner[counter] = allInt[i].get(j);
                    counter += 1;
                }
            }
        }
        return returner;
    }
}
