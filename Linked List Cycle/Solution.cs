/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public boolean hasCycle(ListNode head) {
        Set<ListNode> ref = new HashSet<>();

        while (head != null) {
            if (ref.contains(head)) {
                return true;
            } 
            ref.add(head);
            head = head.next;
        }
        return false;
    }
}
