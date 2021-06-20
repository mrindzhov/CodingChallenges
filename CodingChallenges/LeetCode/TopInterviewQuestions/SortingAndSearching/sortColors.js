/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var sortColors = function (nums = []) {
  let lastZeroIdx = 0;
  let firstTwoIdx = nums.length - 1;
  let index = 0;

  while (index <= firstTwoIdx) {
    if (nums[index] === 0) swap(nums, lastZeroIdx++, index++);
    else if (nums[index] === 1) index++;
    else if (nums[index] === 2) swap(nums, index, firstTwoIdx--);
  }
};

function swap(nums, idx, newIdx) {
  const temp = nums[idx];
  nums[idx] = nums[newIdx];
  nums[newIdx] = temp;
}

sortColors([0, 1, 2, 0, 1, 2]);
sortColors([2, 0, 2, 1, 1, 0]);
sortColors([1, 1, 2, 2, 0, 0]);
