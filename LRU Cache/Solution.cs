class LRUCache {

    class Node {
        int k;
        int val;
        Node prev;
        Node next;
    }
    Map<Integer, Node> ref;
    final Node head = new Node();
    final Node tail = new Node();
    int cap;

    public LRUCache(int capacity) {
        ref = new HashMap<Integer, Node>(cap);
        head.next = tail;
        tail.prev = head;
        cap = capacity;
    }
    
    public int get(int key) {
        if (ref.containsKey(key)) {
            Node updated = ref.get(key);
            removeNode(updated);
            addNode(updated);
            return ref.get(key).val;
        }
        return -1;
    }
    
    public void put(int key, int value) {
        Node checker = ref.get(key);
        if (checker != null) {
            removeNode(checker);
            checker.val = value;
            addNode(checker);
            ref.put(key, checker);
        } else {
            if (ref.size() >= cap) {
                ref.remove(tail.prev.k);
                removeNode(tail.prev);
            }
            Node addedNode = new Node();
            addedNode.k = key;
            addedNode.val = value;
            addNode(addedNode);
            ref.put(key, addedNode); 
        }
    }

    public void addNode(Node newNode) {
        Node oldNode = head.next;
        newNode.prev = head;
        head.next = newNode;
        newNode.next = oldNode;
        oldNode.prev = newNode;
    }

    public void removeNode(Node nodeGone) {
        Node prevNode = nodeGone.prev;
        Node nextNode = nodeGone.next;
        prevNode.next = nextNode;
        nextNode.prev = prevNode;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.get(key);
 * obj.put(key,value);
 */
