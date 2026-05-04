public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int res = 0;
        int l = 0;
        int maxCount = 0;
        for(int r=0;r<s.Length;r++){
            freq[s[r]-'A']++;
            maxCount = Max(maxCount, freq[s[r]-'A']);

            while((r-l+1)-maxCount>k){
                freq[s[l]-'A']-=1;
                l+=1;
            }

            res = Max(res, r-l+1);
        }
        return res;
    }
    public int Max(int a, int b){
        return a>b?a:b;
    }
}
