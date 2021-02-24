/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function (nums) {
  nums.sort(function (a, b) {
    return a - b;
  });
  const result = [];
  for (let i = 0; i < nums.length - 2; i++) {
    if (i === 0 || nums[i] > nums[i - 1]) {
      const x = nums[i];
      let yIdx = i + 1;
      let zIdx = nums.length - 1;
      while (yIdx < zIdx) {
        const y = nums[yIdx];
        const z = nums[zIdx];
        if (x + y + z === 0) result.push([x, y, z]);
        if (x + y + z < 0) while (nums[yIdx] === y && yIdx < zIdx) yIdx++;
        else while (nums[zIdx] === z && yIdx < zIdx) zIdx--;
      }
    }
  }
  return result;
};

threeSum([-1, 0, 1, 2, -1, -4]);
// [-1, 0, 1, 2, -1, -4]
// [-4, -1, -1, 0, 1, 2]
//   ^  ^            ^
