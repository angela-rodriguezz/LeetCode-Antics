<h1>Permutation in String</h1>

Given two strings `s1` and `s2`, return `true` _if_ `s2` _contains a permutation of_ `s1`, _or_ `false` _otherwise._

In other words, return `true` if one of `s1`'s permutations is the substring of `s2`.

<hr>

__Example 1:__

__Input:__ `s1 = "ab", s2 = "eidbaooo"`

__Output:__ `true`

__Explanation:__ `s2 contains one permutation of s1 ("ba").`

__Example 2:__

__Input:__ `s1 = "ab", s2 = "eidboaoo"`

__Output:__ `false`

__Constraints:__

- `1 <= s1.length, s2.length <= 104`
- `s1` and `s2` consist of lowercase English letters.
