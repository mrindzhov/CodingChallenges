/**
 * @param {string} s
 * @return {number}
 */
var longestPalindrome = function (s) {
  const obj = {};
  let res = 0;
  for (let char of s) {
    obj[char] = (obj[char] || 0) + 1;
    if (obj[char] % 2 === 0) res += 2;
  }

  return s.length > res ? res + 1 : res;
};

/**
 * @param {string} s
 * @return {number}
 */
var longestPalindrome2 = function (s) {
  const obj = {};
  for (let i = 0; i < s.length; i++) {
    obj[s[i]] = (obj[s[i]] || 0) + 1;
  }

  let res = Object.values(obj).reduce((acc, value) => {
    acc += Math.floor(value / 2) * 2;

    if (value % 2 == 1 && acc % 2 === 0) {
      acc++;
    }

    return acc;
  }, 0);
  return res;
};
