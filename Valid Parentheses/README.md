<h1>Valid Parentheses</h1>

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every close bracket has a corresponding open bracket of the same type.

<hr>

__Example 1:__
```
Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 ```

__Constraints:__

- `1 <= s.length <= 104`
- `s` consists of parentheses only `'()[]{}'`.
