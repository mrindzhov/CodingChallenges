/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function (strs = []) {
  const baseAscii = 'a'.charCodeAt();
  const arr = Array(26);
  const map = new Map();

  for (const word of strs) {
    const maskKey = [...word]
      .reduce((mask, char) => {
        const letterPos = char.charCodeAt() - baseAscii;
        mask[letterPos]++;
        return mask;
      }, arr.fill(0))
      .join('#');

    const v = map.get(maskKey);
    if (v) v.push(word);
    else map.set(maskKey, [word]);
  }

  return [...map.values()];
};

const strs = ['eat', 'tea', 'tan', 'ate', 'nat', 'bat', 'duh', 'ill'];
const strs2 = [
  'cab',
  'tin',
  'pew',
  'duh',
  'may',
  'ill',
  'buy',
  'bar',
  'max',
  'doc',
];
const val = groupAnagrams(strs);
console.log(val);
