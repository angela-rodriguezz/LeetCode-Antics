class MyHashMap {
    List<Node>[] reference;
    final private int buckets = 10000;

    private class Node {
        int key;
        int value;
        Node(int key, int value) {
            this.key = key;
            this.value = value;
        }
    }

    private int getHash(int k) {
        return k % buckets;
    }

    public MyHashMap() {
        reference = new LinkedList[buckets];
        for (int i = 0; i < buckets; i++) {
            reference[i] = new LinkedList<>();
        }
    }
    
    public void put(int key, int value) {
        int hash = getHash(key);
        
        for (Node check : reference[hash]) {
            if (check.key == key) {
                check.value = value;
                return;
            }
        }
        reference[hash].add(new Node(key, value));
    }
    
    public int get(int key) {
        int hash = getHash(key);
        for (Node check : reference[hash]) {
            if (check.key == key && check != null) {
                return check.value;
            }
        }
        return -1;
    }
    
    public void remove(int key) {
        int hash = getHash(key);
        for (Node check : reference[hash]) {
            if (check.key == key && check != null) {
                reference[hash].remove(check);
                return;
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.put(key,value);
 * int param_2 = obj.get(key);
 * obj.remove(key);
 */
