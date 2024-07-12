class MinStack {

    private int currMin;
    private LinkedList<Integer> ref;
    private LinkedList<Integer> minList;
    public MinStack() {
        currMin = Integer.MAX_VALUE;
        ref = new LinkedList<>();
        minList = new LinkedList<>();
    }
    
    public void push(int val) {
        ref.addFirst(val);

        if (val <= currMin) {
            minList.addFirst(val);
            currMin = val;
        } else {
            minList.addLast(val);
        }
    }
    
    public void pop() {
        if (ref.peek() == currMin) {
            minList.removeFirst();
            currMin = minList.peek();
        }
        ref.removeFirst();
    }
    
    public int top() {
        return ref.peekFirst();
    }
    
    public int getMin() {
        return currMin;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.push(val);
 * obj.pop();
 * int param_3 = obj.top();
 * int param_4 = obj.getMin();
 */
