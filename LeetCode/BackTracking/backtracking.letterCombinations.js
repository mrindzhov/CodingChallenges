/**
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function (digits) {
    //7 & 9
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
    return combinations;
};
console.log(letterCombinations('23'));

/*
  let initialAscii = 'a'.charCodeAt();
  const numberMap = Array(26)
    .fill(0)
    .map(() => initialAscii++);

  console.log(numberMap);

 */

  // console.log('----------------------------');
  // console.log(letterCombinations(''));
  // console.log('----------------------------');
  // console.log(letterCombinations('2'));
