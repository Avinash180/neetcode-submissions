public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length)
        {
            return false;
        }
        int[] s1Counter = new int[26];
        int[] s2Counter = new int[26];
        int i=0;
        for(i=0;i<s1.Length;i++){
            s1Counter[s1[i]-'a']+=1;
            s2Counter[s2[i]-'a']+=1;
        }
        if(IsMatch(s1Counter, s2Counter)){
            return true;
        }
        for(int j=i;j<s2.Length;j++){
            s2Counter[s2[j-s1.Length] -'a'] -=1;
            s2Counter[s2[j]-'a']+=1;
             
            if(IsMatch(s1Counter, s2Counter))
            {
                return true;
            }
        }

        return false;
    }
    public bool IsMatch(int[] s1Counter, int[] s2Counter){
        for(int j=0;j<26;j++){
            if(s1Counter[j]!=s2Counter[j]){
                return false;
            }
        }
        return true;
    }
}
