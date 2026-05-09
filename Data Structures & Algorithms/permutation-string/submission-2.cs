public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        int[] s1Counter = new int[26];
        int[] windowCounter = new int[26];
        int i=0;
        for(i=0;i<s1.Length;i++){
            s1Counter[s1[i]-'a']+=1;
            windowCounter[s2[i]-'a']+=1;
        }
        int matches = 0;
        for(int j=0;j<26;j++){
            if(s1Counter[j]==windowCounter[j]){
                matches++;
            }
        }
        int s1Length = s1.Length;
        int newCharIndex, leftCharIndex;
        for(int r=i;r<s2.Length;r++){
            if(matches==26){
                return true;
            }

            //add new character
            newCharIndex = s2[r]-'a';
            windowCounter[newCharIndex]+=1;

            if(s1Counter[newCharIndex]==windowCounter[newCharIndex]){
                matches+=1;
            }
            else if(s1Counter[newCharIndex] == windowCounter[newCharIndex]-1){
                matches-=1;
            }

            //remove left character
            leftCharIndex = s2[r-s1Length] - 'a';
            windowCounter[leftCharIndex]-=1;

            if(s1Counter[leftCharIndex] == windowCounter[leftCharIndex]){
                matches +=1;
            }
            else if(s1Counter[leftCharIndex] == windowCounter[leftCharIndex]+1){
                matches -=1;
            }
        }

        return matches == 26;
    }
}
