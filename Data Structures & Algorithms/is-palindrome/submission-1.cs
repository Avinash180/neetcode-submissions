public class Solution {
    public bool IsPalindrome(string s) {
        int l=0, r=s.Length-1;
        string lower = s.ToLower();
        while(l<=r){
            if(!char.IsLetterOrDigit(lower[l])){
                l++;
                continue;
            }
            if(!char.IsLetterOrDigit(lower[r])){
                r--;
                continue;
            }
            if(lower[l]!=lower[r]){
                return false;
            }
            l++;
            r--;
        }

        return true;
    }
}
