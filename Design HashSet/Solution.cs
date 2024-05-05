class MyHashSet {
    List<Integer>[] ref;
    private int buckets = 15000;
    private int index = 0;
    private int hashFunction(int k) {
        return k % buckets;
    }

    public MyHashSet() {
        ref = new LinkedList[buckets];
    }
    
    public void add(int key) {
        int i = hashFunction(key);
        if (ref[i] == null) {
            ref[i] = new LinkedList<>();
        }
        if (!ref[i].contains(key)) {
            ref[i].add(key);
        }
    }
    
    public void remove(int key) {
        int i = hashFunction(key);
        if (ref[i] == null) {
            return;
        }
        if (ref[i].contains(key)) {
            ref[i].remove(ref[i].indexOf(key));
        }
    }
    
    public boolean contains(int key) {
        int i = hashFunction(key);
        if (ref[i] == null || !ref[i].contains(key)) {
            return false;
        }
        return true;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.add(key);
 * obj.remove(key);
 * boolean param_3 = obj.contains(key);
 */
