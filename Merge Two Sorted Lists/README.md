<h1>Merge Two Sorted Lists</h1>

You are given the heads of two sorted linked lists `list1` and `list2`.

Merge the two lists into one __sorted__ list. The list should be made by splicing together the nodes of the first two lists.

Return _the head of the merged linked list_.

<hr>

__Example 1:__
```
Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
```
__Example 2:__
```
Input: list1 = [], list2 = []
Output: []
```
__Example 3:__
```
Input: list1 = [], list2 = [0]
Output: [0]
```

__Constraints:__

- The number of nodes in both lists is in the range `[0, 50]`.
- `-100 <= Node.val <= 100`
- Both `list1` and `list2` are sorted in __non-decreasing__ order.
