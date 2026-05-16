public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] counter = new int[26];
            foreach(char c in str){
                counter[c-'a']++;
            }
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<26;i++){
                sb.Append('#');
                sb.Append(counter[i]);
            }

            string key = sb.ToString();
            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        return map.Values.Select(x=>(List<string>)x).ToList();
    }
}
