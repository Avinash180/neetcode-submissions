public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int l=0, r=0, currentSum=0;
        int minSize = int.MaxValue;
        while(r<nums.Length){
            currentSum+=nums[r];
            while(currentSum>=target){
                minSize = Min(minSize, r-l+1);
                currentSum -= nums[l++];
            }
            r++;
        }
        
        return minSize == int.MaxValue ? 0 : minSize;
    }
    public int Min(int a, int b){
        return a>b?b:a;
    }
}