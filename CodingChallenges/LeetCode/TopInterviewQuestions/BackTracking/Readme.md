Backtracking is an algorithm for finding all solutions by exploring all potential candidates. If the solution candidate turns to be not a solution (or at least not the last one), backtracking algorithm discards it by making some changes on the previous step, i.e. backtracks and then try again.

Here is a backtrack function backtrack(combination, next_digits) which takes as arguments an ongoing letter combination and the next digits to check.

If there is no more digits to check that means that the current combination is done.
If there are still digits to check :
Iterate over the letters mapping the next available digit.
Append the current letter to the current combination combination = combination + letter.
Proceed to check next digits : backtrack(combination + letter, next_digits[1:]).
blob:https://leetcode.com/0a6142ad-f64d-497e-8061-dcf99260c621