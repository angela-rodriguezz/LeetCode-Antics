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
    public ListNode reverseBetween(ListNode head, int left, int right) {
        // guarenteed to be a valid input
        if (left == right || head == null) {
            return head;
        }
        ListNode curr = head;
        ListNode prevDummy = new ListNode(0, head);
        ListNode adder = prevDummy;
        int index = 0;
        while (curr != null && index < left - 1) { // want to get to the spaces which need to be switched
            adder = curr; // must add elements to 
            curr = curr.next;;
            index += 1;
        }

        ListNode prev = null;
        ListNode holder = null;
        for (int i = left; i <= right; i++) {
            holder = curr.next;
            curr.next = prev;
            prev = curr;
            curr = holder;
        }

        adder.next.next = curr;
        adder.next = prev;

        return prevDummy.next;
    }
}
