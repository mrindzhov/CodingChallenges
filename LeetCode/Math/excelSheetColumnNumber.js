/**
 * @param {string} s
 * @return {number}
 */
var titleToNumber = function (s) {
  const baseCode = 'A'.charCodeAt();

  return s.split('').reduce((acc, c) => {
    const val = c.charCodeAt() - baseCode + 1;
    return acc * 26 + val;
  }, 0);
};

const res = [
  { Input: 'AB', Output: 28 },
  { Input: 'ABC', Output: 731 },
  { Input: 'BBBC', Output: 36559 },
  { Input: 'ZY', Output: 701 },
].reduce((acc, curr) => {
  const col = titleToNumber(curr.Input);
  acc[curr.Input] = { isMatch: col === curr.Output, col };
  return acc;
}, {});

console.table(res);
