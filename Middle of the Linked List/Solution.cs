/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode middleNode(ListNode head) {
        int length = 0;
        int target = 0;
        ListNode fast = head;
        ListNode slow = head;

        while (fast != null) {
            fast = fast.next;
            length += 1;
        }
        if (length % 2 != 0) {
            target = (int) ((double)length / 2 - 0.5);
        } else {
            target = length / 2;
        }

        while (target != 0) {
            slow = slow.next;
            target -= 1;
        }
        return slow;
    }
}
