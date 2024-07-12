class Solution {
    public int calPoints(String[] operations) {
        // return the sum of all scores after applying all the operations

        Stack<Integer> ref = new Stack<>();
        int sum = 0;
        for (int i = 0; i < operations.length; i++) {
            if (operations[i].equals("C")) {
                if (!ref.isEmpty()) {
                    int val = ref.pop();
                    sum -= val;
                }
            } else if (operations[i].equals("+")) {
                int val1 = ref.pop();
                int val2 = ref.pop();
                ref.push(val2);
                ref.push(val1);
                ref.push(val1 + val2);
                sum += val1 + val2;
            } else if (operations[i].equals("D")) {
                int doubler = ref.peek();
                ref.push(doubler * 2);
                sum += doubler * 2;
            } else {
                int val = Integer.valueOf(operations[i]);
                sum += val;
                ref.push(val);
            }
        }
        return sum;
    }
}
