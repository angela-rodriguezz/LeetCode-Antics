<h1>Linked List Cycle II</h1>

Given the `head` of a linked list, return _the node where the cycle begins. If there is no cycle, return_ `null`.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the `next` pointer. Internally, `pos` is used to denote the index of the node that tail's `next` pointer is connected to (__0-indexed__). It is `-1` if there is no cycle. __Note that `pos` is not passed as a parameter__.

__Do not modify__ the linked list.

<hr>

__Example 1:__
```
Input: head = [3,2,0,-4], pos = 1
Output: tail connects to node index 1
Explanation: There is a cycle in the linked list, where tail connects to the second node.
```
__Example 2:__
```
Input: head = [1,2], pos = 0
Output: tail connects to node index 0
Explanation: There is a cycle in the linked list, where tail connects to the first node.
```
__Example 3:__
```
Input: head = [1], pos = -1
Output: no cycle
Explanation: There is no cycle in the linked list.
```

__Constraints:__

- The number of the nodes in the list is in the range `[0, 10^4]`.
- `-10^5 <= Node.val <= 10^5`
- `pos` is `-1` or a __valid index__ in the linked-list.
