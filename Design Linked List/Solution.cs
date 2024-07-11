class MyLinkedList {

    class Node {
        int val;
        Node prev;
        Node next;
        public Node(int val) {
            this.val = val;
        }
    }
    private int length = 0;
    private Node head;
    private Node tail;

    public MyLinkedList() {
        head = null;
        tail = null;
    }
    
    public int get(int index) {
        if (index < 0 || head == null || index >= length) {
            return -1;
        } 
        Node curr = head;
        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }
        return curr.val;
    }
    
    public void addAtHead(int val) {
        Node noder = new Node(val);
        if (length == 0) {
            head = noder;
            tail = noder;
            length  += 1;
            return;
        }
        noder.next = head;
        head.prev = noder;
        head = noder;
        length += 1;
    }
    
    public void addAtTail(int val) {
        Node newNode = new Node(val);
        if (length == 0) {
            head = newNode;
            tail = newNode;
            length += 1;
            return;
        }
        newNode.prev = tail;
        tail.next = newNode;
        tail = newNode;
        length += 1;
    }
    
    public void addAtIndex(int index, int val) {
        if (index > length) {
            return;
        }
        if (index == length) {
            addAtTail(val);
            return;
        }
        if (index == 0) {
            addAtHead(val);
            return;
        }
        int i = 0;
        Node curr = head;
        while (curr != null && i < index) {
            curr = curr.next;
            i++;
        }
        Node newNode = new Node(val);
        newNode.prev = curr.prev;
        newNode.next = curr;
        curr.prev.next = newNode;
        curr.prev = newNode;
        length += 1;
    }
    
    public void deleteAtIndex(int index) {
        if (index < 0 || head == null || index >= length) {
            return;
        }

        if (index == 0) {
            if (length == 1) {
                head = null;
                tail = null;
            } else {
                head = head.next;
                head.prev = null;
            }
            length--;
            return;
        }
        if (index == length - 1) {
            tail = tail.prev;
            tail.next = null;
            length--;
            return;
        }
        int i = 0;
        Node curr = head;
        while (curr != null && i < index) {
            curr = curr.next;
            i++;
        }
        Node prevNode = curr.prev;
        Node nextNode = curr.next;
        curr.prev.next = nextNode;
        if (curr.next != null) {
            curr.next.prev = prevNode;
        }
        length--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.get(index);
 * obj.addAtHead(val);
 * obj.addAtTail(val);
 * obj.addAtIndex(index,val);
 * obj.deleteAtIndex(index);
 */
