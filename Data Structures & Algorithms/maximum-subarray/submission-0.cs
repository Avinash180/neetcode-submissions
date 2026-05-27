public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int currentSum = 0;

        foreach(int num in nums){
            currentSum = Max(currentSum, 0);
            currentSum += num;
            maxSum = Max(currentSum, maxSum);
        }
        
        return maxSum;
    }
    public int Max(int a,int b){
        return a>b?a:b;
    }
}
