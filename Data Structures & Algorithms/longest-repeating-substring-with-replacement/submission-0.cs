public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int left=0,maxCount=0,maxLength=0;
        for (int right = 0; right < s.Length; right++)
        {
            freq[s[right] - 'A']++;
            maxCount = Math.Max(maxCount, freq[s[right] - 'A']);

            // If invalid window, shrink
            while ((right - left + 1) - maxCount > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
