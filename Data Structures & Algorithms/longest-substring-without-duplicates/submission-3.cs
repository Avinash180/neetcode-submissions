public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        HashSet<char> charSet = new HashSet<char>();
        int l=0;

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
        if(a>b) return a;
        return b;
    }
}
