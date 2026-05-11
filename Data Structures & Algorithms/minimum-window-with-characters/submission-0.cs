public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)){
            return "";
        }

        //Store char frequency of t string in dictionary
        foreach(char c in t){
            if(!freq.ContainsKey(c)){
                freq[c]=0;
            }
            freq[c]+=1;
        }

        int minimumLength = int.MaxValue;
        int needed = freq.Count;
        int formed = 0;

        int l=0;
        int start =0;
        for(int r=0;r<s.Length;r++){
            
            //Store char frequency for each char in s string
            char c = s[r];
            if(!window.ContainsKey(c)){
                window[c]=0;
            }
            window[c]+=1;

            //Increase formed count by 1 if the char is present in freq 
            //and the frequencies match for the char in both the dictionaries
            if(freq.ContainsKey(c) && window[c] == freq[c]){
                formed++;
            }

            //valid window
            while(formed == needed){
                //calculate min length
                if(r-l+1<minimumLength){
                    minimumLength = r-l+1;
                    start = l;
                }

                char leftChar = s[l];
                window[leftChar]-=1;

                //window becomes invalid
                if(freq.ContainsKey(leftChar) && window[leftChar]<freq[leftChar]){
                    formed--;
                }

                l++;
            }
        }

        return minimumLength == int.MaxValue ? "" : s.Substring(start,minimumLength);
    }
}
