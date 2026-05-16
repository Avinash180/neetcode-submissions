public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        for(int r=0; r<9; r++){
            for(int c=0;c<9;c++){
                char num = board[r][c];
                if(num=='.'){
                    continue;
                }

                //check row
                if(!seen.Add("Number " + num + " found in row " + r)){
                    return false;
                }

                //check column
                if(!seen.Add("Number " + num + " found in column " + c)){
                    return false;
                }

                //check box
                int boxRow = r/3;
                int boxColumn = c/3;
                if(!seen.Add("Number " + num + " found in box " + boxRow + "-" + boxColumn)){
                    return false;
                }
            }
        }

        return true;
    }
}
