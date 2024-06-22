class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int[] returner = new int[2];
        int left = 0;
        int right = numbers.length - 1;
        while(true) {
            if (numbers[left] + numbers[right] > target) {
                right--;
            } else if (numbers[left] + numbers[right] < target) {
                left++;
            } else if (numbers[left] + numbers[right] == target) {
                returner[0] = left + 1;
                returner[1] = right + 1;
                break;
            }
        }
        return returner;
    }
}
