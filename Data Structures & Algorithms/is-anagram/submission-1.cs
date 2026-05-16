public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> counter = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(!counter.ContainsKey(c)){
                counter.Add(c,0);
            }
            counter[c]++;
        }

        foreach(char c in t){
            if(!counter.ContainsKey(c)){
                return false;
            }
            counter[c]--;
        }

        foreach(var key in counter.Keys){
            if(counter[key]>=1){
                return false;
            }
        }

        return true;
    }
}
