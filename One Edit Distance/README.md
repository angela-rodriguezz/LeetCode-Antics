<h1>One Edit Distance</h1>

Given two strings `s` and `t`, return `true` if they are both one edit distance apart, otherwise return `false`.

A string `s` is said to be one distance apart from a string `t` if you can:

- Insert __exactly one__ character into `s` to get `t`.
- Delete __exactly one__ character from `s` to get `t`.
- Replace __exactly one__ character of `s` with a different character to get `t`.

<hr>

__Example 1:__
```
Input: s = "ab", t = "acb"
Output: true
Explanation: We can insert 'c' into s to get t.
```
__Example 2:__
```
Input: s = "", t = ""
Output: false
Explanation: We cannot get t from s by only one step.
```

__Constraints:__

- `0 <= s.length, t.length <= 104`
- `s` and `t` consist of lowercase letters, uppercase letters, and digits.
