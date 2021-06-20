/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
  let map = new Map();
  let i = 0,
    j = 0,
    maxLength = 0;

  for (let i = 0, j = 0; j < s.length; j++) {
    i = Math.max(map.get(s[j]) || 0, i);
    maxLength = Math.max(maxLength, j - i + 1);
    map.set(s[j], j + 1);
  }

  return maxLength;
};

/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring2 = function (s) {
  let set = new Set();
  let i = 0,
    j = 0,
    maxLength = 0;

  while (i < s.length && j < s.length) {
    if (!set.has(s[i])) {
      set.add(s[i++]);
      maxLength = Math.max(maxLength, i - j);
    } else {
      set.delete(s[j++]);
    }
  }

  return maxLength;
};

/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring3 = function (s) {
  let maxLength = 0;
  for (let i = 0; i < s.length; i++) {
    let currLength = 1;
    let nextIdx = i + 1;
    while (
      nextIdx <= s.length - 1 &&
      !s.substring(i, nextIdx).includes(s[nextIdx])
    ) {
      nextIdx++;
      currLength++;
    }

    if (currLength > maxLength) {
      maxLength = currLength;
    }
  }
  return maxLength;
};
