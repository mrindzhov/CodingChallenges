/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var searchRange = function (nums, target) {
  let foundIdx = nums[0] === target ? 0 : binarySearchIt(nums, target);

  if (foundIdx === -1) return [-1, -1];

  let startIdx = foundIdx;
  while (startIdx > 0 && nums[startIdx - 1] === target) startIdx--;

  let endIdx = foundIdx;
  while (endIdx < nums.length - 1 && nums[endIdx + 1] === target) endIdx++;

  return [startIdx, endIdx];
};
function binarySearchIt(nums = [], target) {
  let left = 0;
  let right = nums.length - 1;

  while (left <= right) {
    const med = Math.ceil((left + right) / 2);

    if (nums[med] < target) left = med + 1;
    else if (target < nums[med]) right = med - 1;
    else return med;
  }
  return -1;
}

function binarySearchRec(nums = [], target, left, right) {
  if (left > right) return -1;

  const med = Math.ceil((left + right) / 2);

  if (nums[med] < target) {
    return binarySearchRec(nums, target, med + 1, right);
  } else if (target < nums[med]) {
    return binarySearchRec(nums, target, left, med - 1);
  } else {
    return med;
  }
}

/**
Given an array of integers nums sorted in ascending order, 
    find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

Follow up: Could you write an algorithm with O(log n) runtime complexity?


 */

let nums = [5, 7, 7, 8, 8, 10];
let target = 8;
let res = searchRange(nums, target); //Output: [3,4]
console.log(res);
console.log('----------');
nums = [5, 7, 7, 8, 8, 10];
target = 6;
res = searchRange(nums, target); //Output: [-1,-1]
console.log(res);

console.log('----------');
nums = [1];
target = 1;
res = searchRange(nums, target); //Output: [ 0, 0 ]
console.log(res);

console.log('----------');
nums = [2, 2];
target = 2;
res = searchRange(nums, target); //Output: [ 0, 1 ]
console.log(res);

console.log('----------');
nums = [1, 2, 3];
target = 3;
res = searchRange(nums, target); //Output: [ 2, 2 ]
console.log(res);

console.log('----------');
nums = [0, 1, 2, 3, 4, 4, 4];
target = 2;
res = searchRange(nums, target); //Output: [ 2, 2 ]
console.log(res);
