public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new HashSet<char>();
        int l=0, maxLength = 0;
        for(int r=0;r<s.Length;r++){
            while(charSet.Contains(s[r])){
                charSet.Remove(s[l]);
                l+=1;
            }
            charSet.Add(s[r]);
            maxLength = Max(maxLength, r-l+1);
        }
        return maxLength;
    }
    public int Max(int a,int b){
        return a>b?a:b;
    }
}
