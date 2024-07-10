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
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        ListNode merged = new ListNode();
        ListNode adder = merged;

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                adder.next = list1;
                list1 = list1.next;
            } else {
                adder.next = list2;
                list2 = list2.next;
            }
            adder = adder.next;
        }

        if (list1 != null) {
            adder.next = list1;
            list1 = list1.next;
        } if (list2 != null) {
            adder.next = list2;
            list2 = list2.next;
        }
        return merged.next;
    }
}
