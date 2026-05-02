public class Solution {
    public int Search(int[] nums, int target) {
        int l=0;
        int r=nums.Length-1;
        int m=0;
        while(l<=r){
            m= (l+r)/2;
            if(target>nums[m]){
                l=m+1;
            }
            else if(target<nums[m]){
                r=m-1;
            }
            else{
                return m;
            }
        }
        return -1;
    }
}
