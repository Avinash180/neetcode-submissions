public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs){
            int length = str.Length;
            sb.Append(length.ToString());
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i=0;
        while(i<s.Length){
            int j=i;
            while(s[j]!='#'){
                j++;
            }

            int length = int.Parse(s.Substring(i,j-i));

            j++;
            string str = s.Substring(j,length);
            result.Add(str);
            i=j+length;
        }
        return result;
   }
}
