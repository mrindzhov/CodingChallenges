function numIslands(grid: string[][]): number {
    if (!grid?.length) return 0;

    let islandsCount = 0;
    for (let row = 0; row < grid.length; row++) {
        for (let col = 0; col < grid[row].length; col++) {
            if (grid[row][col] === '1') {
                islandsCount += dfs(grid, row, col);
            }
        }
    }
    return islandsCount;
}
function dfs(grid: string[][], row: number, col: number): number {
    if (
        row < 0 ||
        row >= grid.length ||
        col < 0 ||
        col >= grid[row].length ||
        grid[row][col] === '0'
    ) {
        return 0;
    }

    grid[row][col] = '0';
    dfs(grid, row + 1, col);
    dfs(grid, row - 1, col);
    dfs(grid, row, col + 1);
    dfs(grid, row, col - 1);

    return 1;
}