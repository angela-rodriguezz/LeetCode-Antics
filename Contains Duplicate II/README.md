<h1>Contains Duplicate II</h1>

Given an integer array `nums` and an integer `k`, return `true` _if there are two __distinct indices___ `i` and `j` _in the array such that_ `nums[i] == nums[j]` _and_ `abs(i - j) <= k`.

<hr>

__Example 1:__
```
Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
```

__Constraints:__

- `1 <= nums.length <= 10^5`
- `-10^9 <= nums[i] <= 10^9`
- `0 <= k <= 10^5`
