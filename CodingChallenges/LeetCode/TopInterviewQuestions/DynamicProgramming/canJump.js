/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function (nums) {
  let safeSpot = nums.length - 1; // 4
  for (let idx = nums.length - 2; idx >= 0; idx--) {
    const currentJump = nums[idx]; // 1 at idx 3
    const minJump = safeSpot - idx;
    if (currentJump >= minJump) {
      safeSpot = idx;
    } else {
      let attemptedJump = currentJump;
      let criticalMinJump = minJump;
      while (idx >= 0 && attemptedJump < criticalMinJump) {
        idx--;
        criticalMinJump++;
        attemptedJump = nums[idx >= 0 ? idx : 0];
      }

      if (attemptedJump < criticalMinJump) return false;
      else safeSpot = idx;
    }
  }
  return true;
};

console.log(canJump([2, 0, 1, 1, 4]) === true);
console.log('----------------------------');
console.log(canJump([2, 5, 0, 0]) === true);
console.log('----------------------------');
console.log(canJump([0, 1]) === false);
console.log('----------------------------');
console.log(canJump([3, 2, 1, 0, 4]) === false);
