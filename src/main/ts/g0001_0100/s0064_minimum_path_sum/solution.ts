// #Medium #Top_100_Liked_Questions #Array #Dynamic_Programming #Matrix
// #Dynamic_Programming_I_Day_16 #Udemy_Dynamic_Programming #Big_O_Time_O(m*n)_Space_O(m*n)
// #2023_10_01_Time_48_ms_(99.67%)_Space_44.5_MB_(90.16%)

function minPathSum(grid: number[][]): number {
    let [m, n] = [grid.length, grid[0].length]
    let prev = new Array(n + 1).fill(Infinity)
    let cur = new Array(n + 1).fill(0)
    for (let i = 0; i < m; i++) {
        for (let j = 0; j < n; j++) {
            cur[j + 1] = Math.min(prev[j + 1], cur[j]) + grid[i][j]
        }
        prev = cur
        cur = new Array(n + 1)
        cur[0] = Infinity
    }
    return prev[n]
}

export { minPathSum }
