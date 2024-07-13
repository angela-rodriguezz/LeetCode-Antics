class Solution {
    public double findMaxAverage(int[] nums, int k) {
       LinkedList<Integer> ref = new LinkedList<>();
       int maxSum = 0;
       int prevSum = 0;
       for (int i = 0; i < nums.length; i++) {
            if (ref.size() == k) {
                prevSum = prevSum - ref.peekLast() + nums[i];
                if (prevSum > maxSum) {
                    maxSum = prevSum;
                }
                ref.removeLast();
                ref.addFirst(nums[i]);
            } else {
                ref.addFirst(nums[i]);
                maxSum += nums[i];
                prevSum = maxSum;
            }
       }
       return (double) maxSum / k;
    }
}
