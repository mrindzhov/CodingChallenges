/**
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function (digits = '') {
  if (!digits) return [];
  
  const numsMap = {
    2: ['a', 'b', 'c'],
    3: ['d', 'e', 'f'],
    4: ['g', 'h', 'i'],
    5: ['j', 'k', 'l'],
    6: ['m', 'n', 'o'],
    7: ['p', 'q', 'r', 's'],
    8: ['t', 'u', 'v'],
    9: ['w', 'x', 'y', 'z'],
  };
  const combinations = [];

  backtrack('', digits);
  return combinations;

  function backtrack(combinationStr, digitsLeft) {
    if (digitsLeft.length === 0) {
      combinations.push(combinationStr);
      return;
    }
    const letters = numsMap[digitsLeft.charAt(0)];

    for (let i = 0; i < letters.length; i++) {
      const letter = letters[i];
      backtrack(combinationStr + letter, digitsLeft.slice(1));
    }
  }
};
console.log(letterCombinations('23'));
console.log(letterCombinations(''));
console.log(letterCombinations());

// console.log('----------------------------');
// console.log(letterCombinations(''));
// console.log('----------------------------');
// console.log(letterCombinations('2'));
