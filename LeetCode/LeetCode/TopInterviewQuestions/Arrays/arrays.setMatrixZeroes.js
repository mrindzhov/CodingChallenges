/**
 * @param {number[][]} matrix
 * @return {void} Do not return anything, modify matrix in-place instead.
 */
var setZeroes = function (matrix) {
  let firstColHasZeroes = false;
  for (let row = 0; row < matrix.length; row++) {
    if (matrix[row][0] === 0) firstColHasZeroes = true;

    for (let col = 1; col < matrix[row].length; col++) {
      if (matrix[row][col] === 0) {
        matrix[0][col] = 0;
        matrix[row][0] = 0;
      }
    }
  }

  for (let row = 1; row < matrix.length; row++)
    for (let col = 1; col < matrix[row].length; col++)
      if (matrix[row][0] === 0 || matrix[0][col] === 0) matrix[row][col] = 0;

  if (matrix[0][0] === 0) {
    matrix[0] = Array.from(Array(matrix[0].length), () => 0);
  }

  if (firstColHasZeroes) {
    for (let row = 0; row < matrix.length; row++) {
      matrix[row][0] = 0;
    }
  }
};

setZeroes([
  [0, 1, 2, 0],
  [3, 4, 5, 2],
  [1, 3, 0, 5],
]);
