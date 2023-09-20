public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 3; i++) {
            if (examine(0, i * 3, board) == false || examine(3, i * 3, board) == false || examine(6, i * 3, board) == false) {
                return false;
            }
        }
        return checker(board);
    }

    public bool examine(int row, int column, char[][] arr) {
        HashSet<char> reference = new HashSet<char>();
        for (int i = row; i < row + 3; i++) {
            for (int j = column; j < column + 3; j++) {
                if (!(arr[i][j] == '.')) {
                    if (reference.Contains(arr[i][j])) {
                        return false;
                    }
                    reference.Add(arr[i][j]);
                }
            }
        }
        return true;
    }

    public bool checker(char[][] arr) {
        HashSet<char> columner = new HashSet<char>();
        HashSet<char> rower = new HashSet<char>();
        for (int i = 0; i < arr.Length; i++) {
            rower.Clear();
            columner.Clear();
            for (int j = 0; j < arr.Length; j++) {
                if (!(arr[i][j] == '.')) {
                    if (rower.Contains(arr[i][j])) {
                        return false;
                    }
                    rower.Add(arr[i][j]);
                } 
                if (!(arr[j][i] == '.')) {
                    if (columner.Contains(arr[j][i])) {
                        return false;
                    }
                    columner.Add(arr[j][i]);
                }
            }
        }
        return true;
    }
}
