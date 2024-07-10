class Solution {
    public int maxProfit(int[] prices) {
        // choose one say to buy stock & a different day to sell i// return max possible profit
        // if none - > return 0
        // first find lowest value and check if any values afterward increase
        
        int min = prices[0];
        int maxProfit = 0;
        int max = prices[0];

        for (int i = 1; i < prices.length; i++) {
            if (min > prices[i]) {
                min = prices[i];
            } if (prices[i] - min > maxProfit) {
                max = prices[i];
                maxProfit = max - min;
            }
        }
        return maxProfit;
    }
}
