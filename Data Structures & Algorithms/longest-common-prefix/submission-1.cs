public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";

        for(int i=0;i<strs[0].Length;i++){
            foreach(string str in strs){
                if(i==str.Length || str[i] != strs[0][i]){
                    return result;
                }
            }
            result+=strs[0][i];
        }
        return result;
    }
}